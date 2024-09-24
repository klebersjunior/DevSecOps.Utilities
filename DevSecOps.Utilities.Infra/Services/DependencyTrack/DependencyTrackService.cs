using System;
using System.Reflection.PortableExecutable;
using DevSecOps.Utilities.Infra.Model.DependencyTrack;
using Newtonsoft.Json;
using DevSecOps.Utilities.Infra.Service;
using DevSecOps.Utilities.Infra.Util;


namespace DevSecOps.Utilities.Infra.Services.DependencyTrack
{
	public class DependencyTrackService
	{
        HttpService httpService = new HttpService();
        string urlBase = "";
        string token = "";
        public DependencyTrackService(string urlBase, string token)
		{
            this.urlBase = urlBase;
            this.token = token;
		}

        public List<ProjectDTModel> SearchProject(string projectName)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("name", projectName);

            var headers = new Dictionary<string, string>();
            headers.Add("X-Api-Key", token);

            var response = httpService.GetApiAsync($"{urlBase}/api/v1/project", parameters, headers).Result;

            List<ProjectDTModel> products = JsonConvert.DeserializeObject<List<ProjectDTModel>>(response);

            return products;
        }


        public List<ProjectDTModel> GetAllProjects()
        {
            var parameters = new Dictionary<string, string>();
            
            var headers = new Dictionary<string, string>();
            headers.Add("X-Api-Key", token);

            var response = httpService.GetApiAsync($"{urlBase}/api/v1/project", parameters, headers).Result;

            List<ProjectDTModel> products = JsonConvert.DeserializeObject<List<ProjectDTModel>>(response);

            return products;
        }

        public void DeleteProject(string projectId)
        {
            try
            {
                var parameters = new Dictionary<string, string>();

                var headers = new Dictionary<string, string>();
                headers.Add("X-Api-Key", token);

                var response = httpService.DeleteApiAsync($"{urlBase}/api/v1/project/" + projectId, string.Empty, null, headers).Result;
            }
            catch { }
        }

        public ProjectDTModel CreateProject(string projectName, string engagementId)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("X-Api-Key", token);

            string uuid = Guid.NewGuid().ToString();
            var versions = new List<Model.DependencyTrack.Version>();
            versions.Add(new Model.DependencyTrack.Version {
                 Uuid = uuid,
                  VersionNumber = "1"
            });


            var properties = new List<Property>();
            properties.Add(new Property {
                GroupName = "integrations",
                PropertyName = "defectdojo.engagementId",
                PropertyType = "STRING",
                PropertyValue = engagementId
            });

            properties.Add(new Property
            {
                GroupName = "integrations",
                PropertyName = "defectdojo.doNotReactivate",
                PropertyType = "BOOLEAN",
                PropertyValue = "true"
            });

            properties.Add(new Property
            {
                GroupName = "integrations",
                PropertyName = "defectdojo.reimport",
                PropertyType = "BOOLEAN",
                PropertyValue = "true"
            });

            ProjectDTModel productModel = new ProjectDTModel
            {
                Name = projectName,
                Description = projectName,
                Author = UtilEnviroment.CompanyName(),
                Publisher = UtilEnviroment.CompanyName(),
                Group = UtilEnviroment.CompanyName(),
                Classifier = "APPLICATION",
                Uuid = uuid,
                Active = true,
                Version = "1",
                Versions = versions,
                Properties = properties
            };

            var response = httpService.PutApiAsync($"{urlBase}/api/v1/project", JsonConvert.SerializeObject(productModel), headers: headers).Result;
            return JsonConvert.DeserializeObject<ProjectDTModel>(response);

        }

        public void AddDDProperties(ProjectDTModel productModel, string engagementId)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("X-Api-Key", token);

            var response = httpService.PostApiAsync($"{urlBase}/api/v1/project/{productModel.Uuid}/property", JsonConvert.SerializeObject(new Property
            {
                Project = productModel.Uuid,
                GroupName = "integrations",
                PropertyName = "defectdojo.engagementId",
                PropertyType = "STRING",
                PropertyValue = engagementId,
                Description = string.Empty
            }), headers: headers).Result;

            response = httpService.PostApiAsync($"{urlBase}/api/v1/project/{productModel.Uuid}/property", JsonConvert.SerializeObject(new Property
            {
                Project = productModel.Uuid,
                GroupName = "integrations",
                PropertyName = "defectdojo.doNotReactivate",
                PropertyType = "BOOLEAN",
                PropertyValue = "true",
                Description = string.Empty
            }), headers: headers).Result;

            response = httpService.PostApiAsync($"{urlBase}/api/v1/project/{productModel.Uuid}/property", JsonConvert.SerializeObject(new Property
            {
                Project = productModel.Uuid,
                GroupName = "integrations",
                PropertyName = "defectdojo.reimport",
                PropertyType = "BOOLEAN",
                PropertyValue = "true",
                Description = string.Empty
            }), headers: headers).Result;

            
        }


        public async Task UploadBOM(ProjectUploadModel projectUpload)
        {
            var client = new HttpClient();
            client.Timeout = new TimeSpan(0, 20, 0);
            var request = new HttpRequestMessage(HttpMethod.Put, $"{urlBase}/api/v1/bom");
            request.Headers.Add("X-Api-Key", token);
            var content = new StringContent(JsonConvert.SerializeObject(projectUpload), null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            

            if (response.IsSuccessStatusCode)
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            else
            {
                var responseStatus = response.Content.ReadAsStringAsync().Result;


                throw new Exception($"{response.StatusCode.ToString()} - {responseStatus}");
            }
        }

        public async Task<string> ExportFPF(string uuid)
        {
            var parameters = new Dictionary<string, string>();
            
            var headers = new Dictionary<string, string>();
            headers.Add("X-Api-Key", token);

            var response = httpService.GetApiAsync($"{urlBase}/api/v1/finding/project/{uuid}/export", parameters, headers).Result;

            return response;

        }
    }
}

