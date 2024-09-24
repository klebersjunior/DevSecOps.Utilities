// See https://aka.ms/new-console-template for more information
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DependencyTrack;
using DevSecOps.Utilities.Infra.Util;

Console.WriteLine("Hello, World!");

DependencyTrackService dependencyTrackService = new DependencyTrackService(UtilEnviroment.DependencyTrackUrl(), UtilEnviroment.DependencyTrackToken());

var trackProjects = dependencyTrackService.GetAllProjects();
while (trackProjects.Count > 0)
{
    foreach (var item in trackProjects)
    {
        dependencyTrackService.DeleteProject(item.Uuid);
    }  
    trackProjects = dependencyTrackService.GetAllProjects();
}


DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

var projectsDD = defectDojoService.GetProjects().Results;

while (projectsDD.Count > 0)
{
    foreach (var item in projectsDD)
    {
        defectDojoService.DeleteProject(item.Id.Value);
    }

    projectsDD = defectDojoService.GetProjects().Results;
}


