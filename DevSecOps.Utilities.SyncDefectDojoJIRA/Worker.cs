

using Atlassian.Jira;
using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Util;
using System.Text;


namespace DevSecOps.Utilities.SyncDefectDojoJIRA
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
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    
                    Atlassian.Jira.Jira jiraConn = Atlassian.Jira.Jira.CreateRestClient(UtilEnviroment.JIRAUrl(), UtilEnviroment.JIRAUser(), UtilEnviroment.JIRAToken());


                    string EpicKey = UtilEnviroment.JIRAParentEpicKey();

                    DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

                    var ddProjects = defectDojoService.GetProjects();
                    //var ddProjects = defectDojoService.SearchProject("matrix.analytics.functions");

                    foreach (var ddProject in ddProjects.Results)
                    {
                        var findings = defectDojoService.SearchFindingsByProjectName(ddProject.Name);

                        foreach (var finding in findings.Results)
                        {
                            string jiraId = string.Empty;

                            var ddfindingtags = defectDojoService.GetFindingsTags(finding.Id.Value);
                            //Check Finding Exist in JIRA
                            if (ddfindingtags.Tags.Count > 0)
                            {
                                var tagJIRA = ddfindingtags.Tags.FirstOrDefault(x => x.ToUpper().StartsWith("JIRA:"));
                                if (!string.IsNullOrEmpty(tagJIRA))
                                {
                                    jiraId = tagJIRA.Split(':')[1].ToUpper();
                                }
                            }

                            if (!string.IsNullOrEmpty(jiraId))
                            {
                                //Check Status and Update
                                var jiraIssue = await jiraConn.Issues.GetIssueAsync(jiraId);

                                var jiraResolvedStatus = UtilEnviroment.JIRAResolveStatus().Split('-');
                                bool jiraResolved = jiraResolvedStatus.Contains(jiraIssue.Status.Id);

                                if (jiraResolved && finding.Active == true)
                                {
                                    //Closed DefectDojo
                                    defectDojoService.CloseFinding(finding.Id.ToString());
                                }
                                else if (!jiraResolved && finding.Active == false)
                                {
                                    try
                                    {
                                        //Closed JIRA
                                        await jiraIssue.WorkflowTransitionAsync("Vulnerabilidade Priorizada");                                        
                                    }
                                    catch { }

                                    try
                                    {
                                        await jiraIssue.WorkflowTransitionAsync("CONCLUÍDO (2)");
                                    }
                                    catch { }

                                }
                            } 
                            else//Create JIRA
                            {
                                if (finding.Active == true && finding.Verified == true)
                                {
                                    
                                    var issue = jiraConn.CreateIssue(UtilEnviroment.JIRAProjectKey(), EpicKey);
                                    issue.Type = "Vulnerabilidade";

                                    switch (finding.Severity)
                                    {
                                        case "Critical":
                                            issue.Priority = "Crítico";
                                            break;
                                        case "High":
                                            issue.Priority = "Alto";
                                            break;
                                        case "Medium":
                                            issue.Priority = "Médio";
                                            break;
                                        case "Low":
                                            issue.Priority = "Baixo";
                                            break;
                                    }

                                    StringBuilder description = new StringBuilder();

                                    description.AppendLine($"Projeto: {ddProject.Name}");
                                    description.AppendLine("");
                                    description.AppendLine($"{finding.Description}");
                                    
                                    if (!string.IsNullOrEmpty(finding.FilePath))
                                    {
                                        description.AppendLine("");
                                        description.AppendLine($"FilePath: {finding.FilePath}");
                                        description.AppendLine($"Line Number: {finding.Line}");
                                    }
                                    description.AppendLine("");
                                    description.AppendLine($"Date Find: {finding.Date}");

                                    if (!string.IsNullOrEmpty(finding.Mitigation))
                                    {
                                        description.AppendLine("");
                                        description.AppendLine($"Mitigation: {finding.Mitigation}");
                                    }

                                    issue.Summary = finding.Title;
                                    issue.Description = description.ToString();

                                    try
                                    {
                                        if (finding.Cwe > 0)
                                            issue["CWE"] = $"CWE-{finding.Cwe}";
                                    }
                                    catch { }

                                    try
                                    {
                                        if (finding.VulnerabilityIds.Count > 0)
                                            issue["CVE"] = finding.VulnerabilityIds.FirstOrDefault().Vulnerability_Id;
                                    }
                                    catch { }


                                    try
                                    {
                                        issue["ID Externo"] = $"{finding.Id}";
                                    }
                                    catch { }
                                    var createdIssue = await issue.SaveChangesAsync();

                                    //Add DD Tag
                                    if (finding.Tags == null)
                                        finding.Tags = new List<string>();
                                    finding.Tags.Add($"JIRA:{createdIssue.Key}");

                                    defectDojoService.AddFindingTags(finding.Id.Value, finding.Tags);
                                }
                            }
                        }
                    }
                }
                await Task.Delay(1000 * 60 * 5, stoppingToken);
            }
        }
    }
}
