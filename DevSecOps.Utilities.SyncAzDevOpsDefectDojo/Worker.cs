using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra.Model.DependencyTrack;
using DevSecOps.Utilities.Infra.Services.AzDevOps;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DependencyTrack;
using DevSecOps.Utilities.Infra.Util;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using DevSecOps.Utilities.Infra.Util;
using DevSecOps.Utilities.Infra.Services.Cdxgen;
using DevSecOps.Utilities.Infra.Model.Cdxgen;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.SyncAzDevOpsDefectDojo
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker starting running at: {time}", DateTimeOffset.Now);

                    AzDevOpsService azDevOpsService = new AzDevOpsService(UtilEnviroment.AzDevOpsUrl(), UtilEnviroment.AzDevOpsToken());
                    DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

                    DependencyTrackService dependencyTrackService = new DependencyTrackService(UtilEnviroment.DependencyTrackUrl(), UtilEnviroment.DependencyTrackToken());

                    var projects = azDevOpsService.GetAzDevOpsProjects();

                    foreach (var project in projects.value)
                    {
                        var repositories = azDevOpsService.GetAzDevOpsRepos(project.name);
                        foreach (var repository in repositories.value)
                        {
                            try
                            {
                                var projectInfo = defectDojoService.SearchProject(repository.name);
                                ProductModel product;
                                if (projectInfo.Count == 0)
                                {
                                    product = defectDojoService.CreateProject(repository.name);
                                }
                                else
                                {
                                    product = projectInfo.Results.FirstOrDefault();
                                }
                                string importType = "AzDevOpsAdvancedSecurity";

                                //Create DD Engagement
                                var engagementInfo = defectDojoService.SearchEngagement(repository.name, importType);
                                EngagementModel engagement;
                                if (engagementInfo.Count == 0)
                                {
                                    engagement = defectDojoService.CreateEngagement(product.Name, importType, product);
                                }
                                else
                                {
                                    engagement = engagementInfo.Results.FirstOrDefault();
                                }

                                //Create DD Test
                                var testInfo = defectDojoService.SearchTest(repository.name, engagement);
                                TestModel test;
                                if (testInfo.Count == 0)
                                {
                                    test = defectDojoService.CreateTest(product.Name, importType, product, engagement);
                                }
                                else
                                {
                                    test = testInfo.Results.FirstOrDefault();
                                }

                                try
                                {
                                    var alerts = azDevOpsService.GetAlertsProject(project.name, repository.name);
                                    if (alerts.count > 0)
                                        foreach (var alert in alerts.value)
                                        {
                                            //Verifica se a Finding já existe no DefectDojo
                                            var findingResult = defectDojoService.SearchFindingByExternalId(alert.alertId.ToString());

                                            if (findingResult.Results.Count == 0)
                                            {
                                                //Add Finding to DefectDojo se não existir
                                                DDCreateFindingRequestModel finding = new DDCreateFindingRequestModel();
                                                finding.Title = alert.title;
                                                finding.UniqueIdFromTool = alert.alertId.ToString();
                                                finding.VulnIdFromTool = alert.alertId.ToString();
                                                finding.Severity = alert.severity.FirstCharToUpper();
                                                List<int?> foundBy = new List<int?>();
                                                foundBy.Add(1);
                                                finding.FoundBy = foundBy;
                                                finding.Active = true;

                                                StringBuilder description = new StringBuilder();
                                                StringBuilder mitigation = new StringBuilder();

                                                long cwe = 0;


                                                description.AppendLine($"Branch: {alert.gitRef}");
                                                description.AppendLine($"GitUrl: {alert.repositoryUrl}");

                                                if (alert.tools != null)
                                                    foreach (var tool in alert.tools)
                                                    {
                                                        if (tool.rules != null)
                                                            foreach (var rule in tool.rules)
                                                            {
                                                                description.AppendLine(rule.description);
                                                                description.AppendLine(rule.resources);

                                                                mitigation.AppendLine(rule.helpMessage);

                                                                if (rule.tags != null)
                                                                    foreach (var tag in rule.tags)
                                                                    {
                                                                        if (cwe == 0)
                                                                            if (tag.Contains("external/cwe/cwe-"))
                                                                            {
                                                                                cwe = long.Parse(tag.Replace("external/cwe/cwe-", ""));
                                                                            }
                                                                    }

                                                            }
                                                    }
                                                if (cwe > 0)
                                                    finding.Cwe = cwe;

                                                if (alert.logicalLocations != null)
                                                {
                                                    description.AppendLine($"Locations:");
                                                    foreach (var item in alert.logicalLocations)
                                                    {
                                                        description.AppendLine($"Local: {item.fullyQualifiedName}");
                                                    }
                                                }
                                                finding.Description = description.ToString();
                                                finding.Mitigation = mitigation.ToString();

                                                if (alert.physicalLocations != null)
                                                    foreach (var physicalLocation in alert.physicalLocations)
                                                    {
                                                        finding.FilePath = physicalLocation.filePath;
                                                        if (physicalLocation.region != null)
                                                        {
                                                            finding.Line = physicalLocation.region.lineStart;
                                                            finding.ComponentName = repository.name;

                                                        }
                                                    }

                                                finding.PublishDate = DateTime.Now.ToString("yyyy-MM-dd");
                                                finding.Test = test.Id;
                                                finding.Verified = true;

                                                defectDojoService.CreateFinding(finding);
                                            }

                                        }


                                    //Closed Fixed Findings
                                    var closedFindings = azDevOpsService.GetClosedAlertsProject(project.name, repository.name);
                                    if (closedFindings.count > 0)
                                        foreach (var alert in closedFindings.value)
                                        {
                                            var findingResult = defectDojoService.SearchFindingByExternalId(alert.alertId.ToString());
                                            if (findingResult.Results.Count > 0)
                                            {
                                                defectDojoService.CloseFinding(findingResult.Results.FirstOrDefault().Id.ToString());
                                            }
                                        }
                                }
                                catch (Exception ex)
                                {
                                    if (ex.Message.Contains("VS2150009: Advanced Security is not enabled for this repository"))
                                        continue;
                                    else
                                        Console.WriteLine(ex.Message);
                                }


                                //DependencyTrack Scan

                                //Create Project
                                var dTrackProjectResult = dependencyTrackService.SearchProject(project.name);
                                ProjectDTModel dTrackProject;
                                if (dTrackProjectResult.Count == 0)
                                {
                                    dTrackProject = dependencyTrackService.CreateProject(product.Name, engagement.Id.ToString());
                                }
                                else
                                {
                                    dTrackProject = dTrackProjectResult.FirstOrDefault();

                                    if (dTrackProject.Properties == null || dTrackProject.Properties.Count == 0)
                                    {
                                        dependencyTrackService.AddDDProperties(dTrackProject, engagement.Id.ToString());
                                    }
                                }

                                
                                var info = azDevOpsService.GetAzDevOpsRepoInfo(repository.url);

                                if (!string.IsNullOrEmpty(info.remoteUrl))
                                {
                                    List<string> languages = new List<string>();
                                    languages.Add("nodejs");
                                    languages.Add("python");
                                    languages.Add("netcore");
                                    languages.Add("dockerfile");


                                    CdxgenService cdxgenService = new CdxgenService(info.name, info.remoteUrl);
                                    SbomResponse response = null;
                                    foreach (var item in languages)
                                    {
                                        var result = cdxgenService.ExecutePostScan(test, item);
                                        var cItem = JsonConvert.DeserializeObject<SbomResponse>(result);
                                        if (response == null)
                                            response = cItem;
                                        else
                                        {
                                            response.Components.AddRange(cItem.Components);

                                            response.Components = response.Components.Distinct().ToList();

                                            response.Dependencies.AddRange(cItem.Dependencies);
                                            response.Dependencies = response.Dependencies.Distinct().ToList();
                                        }
                                    }


                                    var base64result = JsonConvert.SerializeObject(response).EncodeToBase64();

                                    ProjectUploadModel projectUpload = new ProjectUploadModel();
                                    projectUpload.bom = base64result;
                                    projectUpload.project = dTrackProject.Uuid;

                                    await dependencyTrackService.UploadBOM(projectUpload);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }

                    _logger.LogInformation("Worker stopping running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000 * 60 * 30, stoppingToken);
            }
        }
    }
}
