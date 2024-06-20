using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
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
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                // Ler todos os projetos no GitHub
                GitHubService gitHubService = new GitHubService();
                var gitProjects = gitHubService.SearchGithubProjects(System.Environment.GetEnvironmentVariable("OrgName"));

                foreach (var project in gitProjects)
                {
                    TrufflehogService trufflehogService = new TrufflehogService(project.CloneUrl, UtilEnviroment.GitUser(), UtilEnviroment.GitPass());

                    DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());
                    string importType ="trufflehog";
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
                    else {
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

                    trufflehogService.ExecuteScan(test);
                }
                


            }
            await Task.Delay(1000 * 60 * 60, stoppingToken);
        }
    }
}
