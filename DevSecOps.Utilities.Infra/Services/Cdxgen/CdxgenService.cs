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
            var result = httpService.GetApiAsync($"{UtilEnviroment.SbomUrl()}/sbom?",parameters).Result;

            return result;
        }

    }
}