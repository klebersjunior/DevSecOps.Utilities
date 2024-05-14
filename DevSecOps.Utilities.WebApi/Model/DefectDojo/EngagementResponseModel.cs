using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.WebApi.Model.DefectDojo
{
	

    public class EngagementModel
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Tags { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public object Version { get; set; }

        [JsonProperty("first_contacted", NullValueHandling = NullValueHandling.Ignore)]
        public object FirstContacted { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetEnd { get; set; }

        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public object Reason { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public object Tracker { get; set; }

        [JsonProperty("test_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public object TestStrategy { get; set; }

        [JsonProperty("threat_model", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ThreatModel { get; set; }

        [JsonProperty("api_test", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApiTest { get; set; }

        [JsonProperty("pen_test", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PenTest { get; set; }

        [JsonProperty("check_list", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckList { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        [JsonProperty("tmodel_path", NullValueHandling = NullValueHandling.Ignore)]
        public string TmodelPath { get; set; }

        [JsonProperty("done_testing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoneTesting { get; set; }

        [JsonProperty("engagement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngagementType { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public object BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public object CommitHash { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public object BranchTag { get; set; }

        [JsonProperty("source_code_management_uri", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceCodeManagementUri { get; set; }

        [JsonProperty("deduplication_on_engagement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeduplicationOnEngagement { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lead { get; set; }

        [JsonProperty("requester", NullValueHandling = NullValueHandling.Ignore)]
        public object Requester { get; set; }

        [JsonProperty("preset", NullValueHandling = NullValueHandling.Ignore)]
        public object Preset { get; set; }

        [JsonProperty("report_type", NullValueHandling = NullValueHandling.Ignore)]
        public object ReportType { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; }

        [JsonProperty("build_server", NullValueHandling = NullValueHandling.Ignore)]
        public object BuildServer { get; set; }

        [JsonProperty("source_code_management_server", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceCodeManagementServer { get; set; }

        [JsonProperty("orchestration_engine", NullValueHandling = NullValueHandling.Ignore)]
        public object OrchestrationEngine { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Notes { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Files { get; set; }

        [JsonProperty("risk_acceptance", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> RiskAcceptance { get; set; }
    }

    public class EngagementResponseModel
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public object Next { get; set; }

        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public object Previous { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<EngagementModel> Results { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }
    }
}

