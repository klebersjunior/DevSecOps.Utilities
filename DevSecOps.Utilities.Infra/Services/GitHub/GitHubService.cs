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
using DevSecOps.Utilities.Infra.Model.Trufflehog;


namespace DevSecOps.Utilities.Infra.Services.GitHub
{
    public class GitHubService
    {
        HttpService httpService = new HttpService();

        public List<GitHubSearchResponse> SearchGithubProjects(string orgName)
        {
            List<GitHubSearchResponse> results = new List<GitHubSearchResponse>();

            Dictionary<string,string> parameters = new Dictionary<string,string>();
            Dictionary<string,string> headers = new Dictionary<string,string>();
            headers.Add("Authorization", $"Bearer {UtilEnviroment.GitPass}");

            int page = 1;
            bool continueExec = true;
            while (continueExec)
            {
                var response = httpService.GetApiAsync($"https://api.github.com/orgs/{orgName}/repos?page={page}", parameters, headers).Result;

                if(string.IsNullOrEmpty(response))
                {
                    continueExec = false;;
                }

                var data = JsonConvert.DeserializeObject<List<GitHubSearchResponse>>(response);
                
                if(data.Count == 0)
                {
                    continueExec = false;
                }

                results.AddRange(data);
            }


            return results;
        }

    }
}