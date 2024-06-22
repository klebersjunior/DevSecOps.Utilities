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

            
            
            Dictionary<string,string> headers = new Dictionary<string,string>();
            headers.Add("Authorization", $"Bearer {UtilEnviroment.GitPass()}");
            headers.Add("User-Agent", $"Console .NET");

            int page = 1;
            bool continueExec = true;
            while (continueExec)
            {

                Dictionary<string,string> parameters = new Dictionary<string,string>();
                parameters.Add("page", page.ToString());
                var response = httpService.GetApiAsync($"https://api.github.com/orgs/{orgName}/repos", parameters, headers).Result;

                if(string.IsNullOrEmpty(response))
                {
                    continueExec = false;
                    continue;
                }

                var data = JsonConvert.DeserializeObject<List<GitHubSearchResponse>>(response);
                
                if(data.Count == 0)
                {
                    continueExec = false;
                    continue;
                }

                results.AddRange(data);
                page = page+1;
            }


            return results;
        }

    }
}