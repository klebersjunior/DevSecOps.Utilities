using System;
using System.IO;
using System.Reflection.PortableExecutable;
using DevSecOps.Utilities.Infra.Model.DefectDojo;
using DevSecOps.Utilities.Infra;
using Newtonsoft.Json;
using DevSecOps.Utilities.Infra.Service;
using Microsoft.AspNetCore.Http;

namespace DevSecOps.Utilities.Infra.Services.DefectDojo
{
	public class DefectDojoService
	{
		HttpService httpService = new HttpService();

        string urlBase = string.Empty;
        string token = string.Empty;

		public DefectDojoService(string urlBase, string token)
		{
            this.urlBase = urlBase;
            this.token = token;
		}

		public ProductSearchResponseModel SearchProject(string projectName)
		{
			var parameters = new Dictionary<string, string>();
			parameters.Add("name", projectName);

			var headers = new Dictionary<string, string>();
			headers.Add("Authorization", $"Token {token}");

			var response = httpService.GetApiAsync(urlBase + "/api/v2/products/", parameters, headers).Result;

			ProductSearchResponseModel products = JsonConvert.DeserializeObject<ProductSearchResponseModel>(response);

			return products;
		}

        public ProductModel CreateProject(string projectName)
		{
			var headers = new Dictionary<string, string>();
			headers.Add("Authorization", $"Token {token}");

			ProductModel productModel = new ProductModel
			{
				Name = projectName,
				Description = projectName,
				BusinessCriticality = "very high",
				ProdType = 1,
				SlaConfiguration = 1

			};

            var response = httpService.PostApiAsync(urlBase + "/api/v2/products/", JsonConvert.SerializeObject(productModel), headers: headers).Result;
			return JsonConvert.DeserializeObject<ProductModel>(response);

        }


        public EngagementResponseModel SearchEngagement(string projectName, string typeEngagement)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("name", $"{projectName}_{typeEngagement}");

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            var response = httpService.GetApiAsync(urlBase + "/api/v2/engagements/", parameters, headers).Result;

            EngagementResponseModel engagement = JsonConvert.DeserializeObject<EngagementResponseModel>(response);

            return engagement;
        }

        public EngagementModel CreateEngagement(string projectName, string typeEngagement, ProductModel product)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            EngagementModel engagementModel = new EngagementModel {
                Active = true,
                Name = $"{projectName}_{typeEngagement}",
                Lead = product.TeamManager.HasValue ? product.TeamManager.Value : 1,
                Product = product.Id,
                TargetStart = DateTime.Now.ToString("yyyy-MM-dd"),
                TargetEnd = DateTime.Now.ToString("yyyy-MM-dd"),
                EngagementType = "CI/CD"
            };


            var response = httpService.PostApiAsync(urlBase + "/api/v2/engagements/", JsonConvert.SerializeObject(engagementModel), headers: headers).Result;
            return JsonConvert.DeserializeObject<EngagementModel>(response);

        }

        public DDCloseFindingRequestModel CloseFinding(string findingId)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            DDCloseFindingRequestModel model = new DDCloseFindingRequestModel
            {
                duplicate = false,
                false_p = false,
                is_mitigated = true,
                out_of_scope = false,
                mitigated = DateTime.Now
            };

             var response = httpService.PostApiAsync(urlBase + $"/api/v2/findings/{findingId}/close/", JsonConvert.SerializeObject(model), headers: headers).Result;
            return JsonConvert.DeserializeObject<DDCloseFindingRequestModel>(response);

        }

        public DDCreateFindingResponseModel CreateFinding(DDCreateFindingRequestModel finding)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            switch (finding.Severity)
            {
                case "Critical":
                    finding.NumericalSeverity = "S0";
                    break;
                case "High":
                    finding.NumericalSeverity = "S1";
                    break;

                case "Medium":
                    finding.NumericalSeverity = "S2";
                    break;

                case "Low":
                    finding.NumericalSeverity = "S3";
                    break;

                default:
                    finding.NumericalSeverity = "S4";
                    break;
            }

            var response = httpService.PostApiAsync(urlBase + "/api/v2/findings/", JsonConvert.SerializeObject(finding), headers: headers).Result;
            return JsonConvert.DeserializeObject<DDCreateFindingResponseModel>(response);

        }


        public DDSearchFindingModel SearchFindingByExternalId(string externalId)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("unique_id_from_tool", externalId);

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            var response = httpService.GetApiAsync(urlBase + "/api/v2/findings/", parameters, headers).Result;
            return JsonConvert.DeserializeObject<DDSearchFindingModel>(response);

        }

        public TestResponseModel SearchTest(string projectName, EngagementModel engagement)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("engagement", engagement.Id.ToString());

            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            var response = httpService.GetApiAsync(urlBase + "/api/v2/tests/", parameters, headers).Result;

            TestResponseModel test = JsonConvert.DeserializeObject<TestResponseModel>(response);

            return test;
        }

        public TestModel CreateTest(string projectName, string typeEngagement, ProductModel product, EngagementModel engagement)
        {
            var headers = new Dictionary<string, string>();
            headers.Add("Authorization", $"Token {token}");

            int typeScanId = 1;
            switch (typeEngagement)
            {
                case "horusec":
                    typeScanId = 157;
                    break;
                case "dependencyTrack":
                    typeScanId = 34;
                    break;
                case "truflehog":
                    typeScanId = 165;
                    break;
                case "AzDevOpsAdvancedSecurity":
                    typeScanId = 188;
                    break;
                default:
                    break;
            }

            TestModel engagementModel = new TestModel
            {
                Lead = product.TeamManager.HasValue ? product.TeamManager.Value : 1,
                Engagement = engagement.Id,
                Title = $"{projectName}_{typeEngagement}",
                TargetStart = DateTime.Now,
                TargetEnd = DateTime.Now.AddYears(1),
                Environment = 3,
                TestType = typeScanId,                
            };

            var response = httpService.PostApiAsync(urlBase + "/api/v2/tests/", JsonConvert.SerializeObject(engagementModel), headers: headers).Result;
            return JsonConvert.DeserializeObject<TestModel>(response);

        }

        public async Task ReimportScan(TestModel test, IFormFile importFile, string commitHash = "", string buildId = "", string branch_tag = "")
        {
            using (var file = new MemoryStream())
            {
                importFile.CopyTo(file);
                file.Seek(0, SeekOrigin.Begin);


                try
                {
                    var client = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Post, urlBase + "/api/v2/reimport-scan/");
                    request.Headers.Add("accept", "application/json");
                    request.Headers.Add("Authorization", $"Token {token}");
                    var content = new MultipartFormDataContent();
                    content.Add(new StringContent(""), "product_type_name");
                    content.Add(new StringContent("true"), "active");
                    content.Add(new StringContent("false"), "do_not_reactivate");
                    content.Add(new StringContent(""), "endpoint_to_add");
                    content.Add(new StringContent("false"), "verified");
                    content.Add(new StringContent("true"), "close_old_findings");
                    content.Add(new StringContent(""), "test_title");
                    content.Add(new StringContent(""), "engagement_name");
                    content.Add(new StringContent(buildId), "build_id");
                    content.Add(new StringContent("true"), "deduplication_on_engagement");
                    content.Add(new StringContent("false"), "push_to_jira");
                    content.Add(new StringContent("Info"), "minimum_severity");
                    content.Add(new StringContent("false"), "close_old_findings_product_scope");

                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    content.Add(new StringContent(date), "scan_date");
                    content.Add(new StringContent(""), "create_finding_groups_for_all_findings");


                    content.Add(new StringContent(date), "engagement_end_date");
                    content.Add(new StringContent(test.Id.ToString()), "test");
                    content.Add(new StringContent("Production"), "environment");
                    content.Add(new StringContent(""), "service");
                    content.Add(new StringContent(commitHash), "commit_hash");
                    content.Add(new StringContent(""), "group_by");
                    content.Add(new StringContent(""), "version");
                    //content.Add(new StringContent("horusec"), "tags");
                    content.Add(new StringContent(""), "api_scan_configuration");
                    content.Add(new StringContent(""), "product_name");
                    
                    content.Add(new StringContent("true"), "auto_create_context");
                    content.Add(new StringContent(""), "lead");
                    content.Add(new StringContent(test.TestTypeName), "scan_type");
                    content.Add(new StringContent(branch_tag), "branch_tag");
                    content.Add(new StringContent(""), "source_code_management_uri");

                    content.Add(new StreamContent(file), "file", "import.json");
                    request.Content = content;
                    var response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        throw new Exception($"{response.StatusCode.ToString()} - {response.Content.ReadAsStringAsync().Result}");
                    }

                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public async Task ReimportScan(TestModel test, Stream importFile, string commitHash = "", string buildId = "", string branch_tag = "")
        {
            using (var file = new MemoryStream())
            {
                importFile.CopyTo(file);
                file.Seek(0, SeekOrigin.Begin);


                try
                {
                    var client = new HttpClient();
                    var request = new HttpRequestMessage(HttpMethod.Post, urlBase + "/api/v2/reimport-scan/");
                    request.Headers.Add("accept", "application/json");
                    request.Headers.Add("Authorization", $"Token {token}");
                    var content = new MultipartFormDataContent();
                    content.Add(new StringContent(""), "product_type_name");
                    content.Add(new StringContent("true"), "active");
                    content.Add(new StringContent("false"), "do_not_reactivate");
                    content.Add(new StringContent(""), "endpoint_to_add");
                    content.Add(new StringContent("false"), "verified");
                    content.Add(new StringContent("true"), "close_old_findings");
                    content.Add(new StringContent(""), "test_title");
                    content.Add(new StringContent(""), "engagement_name");
                    content.Add(new StringContent(buildId), "build_id");
                    content.Add(new StringContent("true"), "deduplication_on_engagement");
                    content.Add(new StringContent("false"), "push_to_jira");
                    content.Add(new StringContent("Info"), "minimum_severity");
                    content.Add(new StringContent("false"), "close_old_findings_product_scope");

                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    content.Add(new StringContent(date), "scan_date");
                    content.Add(new StringContent(""), "create_finding_groups_for_all_findings");


                    content.Add(new StringContent(date), "engagement_end_date");
                    content.Add(new StringContent(test.Id.ToString()), "test");
                    content.Add(new StringContent("Production"), "environment");
                    content.Add(new StringContent(""), "service");
                    content.Add(new StringContent(commitHash), "commit_hash");
                    content.Add(new StringContent(""), "group_by");
                    content.Add(new StringContent(""), "version");
                    //content.Add(new StringContent("horusec"), "tags");
                    content.Add(new StringContent(""), "api_scan_configuration");
                    content.Add(new StringContent(""), "product_name");

                    content.Add(new StringContent("true"), "auto_create_context");
                    content.Add(new StringContent(""), "lead");
                    content.Add(new StringContent(test.TestTypeName), "scan_type");
                    content.Add(new StringContent(branch_tag), "branch_tag");
                    content.Add(new StringContent(""), "source_code_management_uri");

                    content.Add(new StreamContent(file), "file", "import.json");
                    request.Content = content;
                    var response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        response.EnsureSuccessStatusCode();
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                    }
                    else
                    {
                        throw new Exception($"{response.StatusCode.ToString()} - {response.Content.ReadAsStringAsync().Result}");
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        
    }
}

