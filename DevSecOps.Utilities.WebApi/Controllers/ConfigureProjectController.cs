using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DevSecOps.Utilities.Infra.Model;
using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra.Model.DependencyTrack;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Services.DependencyTrack;
using DevSecOps.Utilities.Infra.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevSecOps.Utilities.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigureProjectController : ControllerBase
    {
        // POST: api/ConfigureProject
        [HttpPost]
        public void Post([FromBody] DevSecOpsProjectModel project)
        {
            DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

            //Create DefectDojo Project
            var projectInfo = defectDojoService.SearchProject(project.ProjectName);
            ProductModel product;
            if (projectInfo.Count == 0)
            {
                product = defectDojoService.CreateProject(project.ProjectName);
            }
            else
            {
                product = projectInfo.Results.FirstOrDefault();
            }

            //Create DependencyTrack Project
            DependencyTrackService dependencyTrackService = new DependencyTrackService(UtilEnviroment.DependencyTrackUrl(), UtilEnviroment.DependencyTrackToken());

            var projectDTInfo = dependencyTrackService.SearchProject(project.ProjectName);
            ProjectDTModel productDT;
            if (projectDTInfo.Count == 0)
            {
                productDT = dependencyTrackService.CreateProject(project.ProjectName, string.Empty);
            }
            else
            {
                productDT = projectDTInfo.FirstOrDefault();
            }

        }


        [HttpPost("Import")]
        public async Task ImportDD([FromQuery] string projectName, [FromQuery] string importType, [FromForm] IFormFile importFile)
        {
            DefectDojoService defectDojoService = new DefectDojoService(UtilEnviroment.DefectDojoUrl(), UtilEnviroment.DefectDojoToken());

            //Create DefectDojo Project
            var projectInfo = defectDojoService.SearchProject(projectName);
            ProductModel product;
            if (projectInfo.Count == 0)
            {
                product = defectDojoService.CreateProject(projectName);
            }
            else
            {
                product = projectInfo.Results.FirstOrDefault();
            }

            //Create DD Engagement
            var engagementInfo = defectDojoService.SearchEngagement(projectName, importType);
            EngagementModel engagement;
            if (engagementInfo.Count == 0)
            {
                engagement = defectDojoService.CreateEngagement(product.Name, importType, product);
            }
            else {
                engagement = engagementInfo.Results.FirstOrDefault();
            }

            //Create DD Test
            var testInfo = defectDojoService.SearchTest(projectName, engagement);
            TestModel test;
            if (testInfo.Count == 0)
            {
                test = defectDojoService.CreateTest(product.Name, importType, product, engagement);
            }
            else
            {
                test = testInfo.Results.FirstOrDefault();
            }

            if (importType == "dependencyTrack")
            {
                DependencyTrackService dependencyTrackService = new DependencyTrackService(UtilEnviroment.DependencyTrackUrl(), UtilEnviroment.DependencyTrackToken());

                //Create Project
                var dTrackProjectResult = dependencyTrackService.SearchProject(projectName);
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

                //Import SBOM
                var result = new StringBuilder();
                using (var reader = new StreamReader(importFile.OpenReadStream()))
                {
                    while (reader.Peek() >= 0)
                    {
                        result.AppendLine(reader.ReadLine());
                    }
                }

                var base64result = result.ToString().EncodeToBase64();

                ProjectUploadModel projectUpload = new ProjectUploadModel();
                projectUpload.bom = base64result;
                projectUpload.project = dTrackProject.Uuid;

                await dependencyTrackService.UploadBOM(projectUpload);

                //Configure Project Properties
            }
            else {
                //upload file result
                await defectDojoService.ReimportScan(test, importFile);
            }


            
        }
    }
}
