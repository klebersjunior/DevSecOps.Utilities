using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.Infra.Model
{
	public class DevSecOpsProjectModel
	{
		[JsonProperty("projectName")]
		public string ProjectName { get; set; }

        [JsonProperty("githubUrl")]
        public string GithubUrl { get; set; }

    }
}

