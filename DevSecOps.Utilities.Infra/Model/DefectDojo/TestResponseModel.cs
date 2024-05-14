using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.Infra.Model.DefectDojo
{

    public class TestModel
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("test_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTypeName { get; set; }

        [JsonProperty("finding_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> FindingGroups { get; set; }

        [JsonProperty("scan_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanType { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public object Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public object Description { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetEnd { get; set; }

        [JsonProperty("estimated_time", NullValueHandling = NullValueHandling.Ignore)]
        public object EstimatedTime { get; set; }

        [JsonProperty("actual_time", NullValueHandling = NullValueHandling.Ignore)]
        public object ActualTime { get; set; }

        [JsonProperty("percent_complete", NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentComplete { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public int Lead { get; set; }

        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; }

        [JsonProperty("api_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApiScanConfiguration { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Notes { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<object>? Files { get; set; }
    }

    public class TestResponseModel
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public object Next { get; set; }

        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public object Previous { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestModel> Results { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }
    }
}

