using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra.Model.DependencyTrack;
using DevSecOps.Utilities.Infra.Services.Cdxgen;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DependencyTrack;
using DevSecOps.Utilities.Infra.Services.GitHub;
using DevSecOps.Utilities.Infra.Services.Trufflehog;
using DevSecOps.Utilities.Infra.Util;

namespace DevSecOps.Utilities.RunAllProjects;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var executeModulesVariable = System.Environment.GetEnvironmentVariable("Execution");
        bool executeTruflehog = true;
        bool executeCdxGen = true;

        if (!string.IsNullOrEmpty(executeModulesVariable))
        {
            var executeModules = executeModulesVariable.Split(',');

            if (executeModules.Any(x => x == "truflehog"))
                executeTruflehog = true;
            else
                executeTruflehog = false;

            if (executeModules.Any(x => x == "cdxgen"))
                executeCdxGen = true;
            else
                executeCdxGen = false;
        }


        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                // Ler todos os projetos no GitHub
                GitHubService gitHubService = new GitHubService();
                var gitProjects = gitHubService.SearchGithubProjects(System.Environment.GetEnvironmentVariable("OrgName"));

                foreach (var project in gitProjects)
                {
                    try
                    {
                        TrufflehogService trufflehogService = new TrufflehogService(project.CloneUrl, UtilEnviroment.GitUser(), UtilEnviroment.GitPass());

                        DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());
                        string importType = "trufflehog";
                        //Create DefectDojo Project
                        var projectInfo = defectDojoService.SearchProject(project.Name);
                        ProductModel product;
                        if (projectInfo.Count == 0)
                        {
                            product = defectDojoService.CreateProject(project.Name);
                        }
                        else
                        {
                            product = projectInfo.Results.FirstOrDefault();
                        }

                        //Create DD Engagement
                        var engagementInfo = defectDojoService.SearchEngagement(project.Name, importType);
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
                        var testInfo = defectDojoService.SearchTest(project.Name, engagement);
                        TestModel test;
                        if (testInfo.Count == 0)
                        {
                            test = defectDojoService.CreateTest(product.Name, importType, product, engagement);
                        }
                        else
                        {
                            test = testInfo.Results.FirstOrDefault();
                        }

                        if(executeTruflehog)
                            trufflehogService.ExecuteScan(test);

                        DependencyTrackService dependencyTrackService = new DependencyTrackService(UtilEnviroment.DependencyTrackUrl(), UtilEnviroment.DependencyTrackToken());

                        //Create Project
                        var dTrackProjectResult = dependencyTrackService.SearchProject(project.Name);
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

                        if (executeCdxGen)
                        {
                            CdxgenService cdxgenService = new CdxgenService(project.Name, project.CloneUrl);
                            var result = cdxgenService.ExecuteScan(test);

                            var base64result = result.ToString().EncodeToBase64();

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
            await Task.Delay(1000 * 60 * 60 * 12, stoppingToken);
        }
    }
}
