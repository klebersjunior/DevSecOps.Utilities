using System;
using System.IO;
using System.Reflection.PortableExecutable;
using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra;
using Newtonsoft.Json;
using DevSecOps.Utilities.Infra.Service;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Text;
using DevSecOps.Utilities.Infra.Services.DefectDojo;
using DevSecOps.Utilities.Infra.Util;
using DevSecOps.Utilities.Infra.Services.DependencyTrack;
using DevSecOps.Utilities.Infra.Model.Cdxgen;



namespace DevSecOps.Utilities.Infra.Services.Cdxgen
{


    public class CdxgenService
    {
        private string ProjectName {get;set;}
        string GitUrl { get; set; }

        public CdxgenService(string projectName,string gitUrl)
        {
            this.ProjectName = projectName;
            this.GitUrl = gitUrl;
        }

        public string ExecuteScan(TestModel test)
        {            
            HttpService httpService = new HttpService();

            Dictionary<string,string> parameters = new Dictionary<string,string>();
            parameters.Add("url", $"https://{UtilEnviroment.GitUser()}:{UtilEnviroment.GitPass()}@{this.GitUrl.Replace("https://", "")}");
            parameters.Add("multiProject", $"true");
            var result = httpService.GetApiAsync($"{UtilEnviroment.SbomUrl()}/sbom",parameters).Result;

            return result;
        }

        public string ExecutePostScan(TestModel test, string type, string productId)
        {
            HttpService httpService = new HttpService();


            SbomRequest sbomRequest = new SbomRequest();
            sbomRequest.multiProject = "true";
            sbomRequest.type = type;
            sbomRequest.serverUrl = UtilEnviroment.DependencyTrackUrl(); ;
            sbomRequest.apiKey = UtilEnviroment.DependencyTrackToken();
            sbomRequest.projectId = productId;

            string azOrgName = System.Environment.GetEnvironmentVariable("AzDevOpsOrgName");
            if(string.IsNullOrEmpty(azOrgName))
                sbomRequest.url = $"https://{UtilEnviroment.GitUser()}:{UtilEnviroment.GitPass()}@{this.GitUrl.Replace("https://", "")}";
            else
                sbomRequest.url = $"https://{UtilEnviroment.GitPass()}@{this.GitUrl.Replace("https://", "").Replace(azOrgName, "")}";

            
            var result = httpService.PostApiAsync($"{UtilEnviroment.SbomUrl()}/sbom", JsonConvert.SerializeObject(sbomRequest)).Result;

            return result;
        }

    }
}