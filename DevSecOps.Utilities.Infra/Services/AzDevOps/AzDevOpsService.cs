
using DevSecOps.Utilities.Infra.Model.AzDevOps;
using DevSecOps.Utilities.Infra.Service;
using DevSecOps.Utilities.Infra.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Services.AzDevOps
{
    public class AzDevOpsService
    {
        HttpService httpService = new HttpService();

        string urlBase = string.Empty;

        string token = string.Empty;

        public AzDevOpsService(string urlBase, string token)
        {
            this.urlBase = urlBase;
            this.token = token;
        }

        public AzDevOpsAlertsResult GetAlertsProject(string projectName, string repositoryName)
        {
            var parameters = new Dictionary<string, string>();

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Basic {Conversor.EncodeToBase64($"Basic:{token}")}");

            var response = httpService.GetApiAsync($"https://advsec.{urlBase}/{projectName}/_apis/alert/repositories/{repositoryName}/alerts?api-version=7.2-preview.1&criteria.onlyDefaultBranchAlerts=true&criteria.states=active", parameters, headers).Result;

            AzDevOpsAlertsResult products = JsonConvert.DeserializeObject<AzDevOpsAlertsResult>(response);

            return products;
        }

        public AzDevOpsAlertsResult GetClosedAlertsProject(string projectName, string repositoryName)
        {
            var parameters = new Dictionary<string, string>();

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Basic {Conversor.EncodeToBase64($"Basic:{token}")}");

            var response = httpService.GetApiAsync($"https://advsec.{urlBase}/{projectName}/_apis/alert/repositories/{repositoryName}/alerts?api-version=7.2-preview.1&criteria.onlyDefaultBranchAlerts=true&criteria.states=fixed", parameters, headers).Result;

            AzDevOpsAlertsResult products = JsonConvert.DeserializeObject<AzDevOpsAlertsResult>(response);

            return products;
        }

        public AzDevOpsProjectResult GetAzDevOpsProjects()
        {
            var parameters = new Dictionary<string, string>();

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Basic {Conversor.EncodeToBase64($"Basic:{token}")}");

            var response = httpService.GetApiAsync($"https://{urlBase}//_apis/projects?api-version=5.0", parameters, headers).Result;

            AzDevOpsProjectResult products = JsonConvert.DeserializeObject<AzDevOpsProjectResult>(response);

            return products;
        }

        public AzDevOpsProjectResult GetAzDevOpsRepos(string projectName)
        {
            var parameters = new Dictionary<string, string>();

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Basic {Conversor.EncodeToBase64($"Basic:{token}")}");

            var response = httpService.GetApiAsync($"https://{urlBase}/{projectName}/_apis/git/repositories?api-version=7.2-preview.1", parameters, headers).Result;

            AzDevOpsProjectResult products = JsonConvert.DeserializeObject<AzDevOpsProjectResult>(response);

            return products;
        }

        public AzDevOpsRepoInfo GetAzDevOpsRepoInfo(string url)
        {
            var parameters = new Dictionary<string, string>();

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Basic {Conversor.EncodeToBase64($"Basic:{token}")}");

            var response = httpService.GetApiAsync(url, parameters, headers).Result;



            AzDevOpsRepoInfo products = JsonConvert.DeserializeObject<AzDevOpsRepoInfo>(response);

            return products;
        }
    }
}
