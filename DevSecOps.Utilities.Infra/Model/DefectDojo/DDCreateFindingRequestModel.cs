using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.DefectDojo
{

    public class DDCreateFindingRequestModel
    {
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThreadId { get; set; }

        [JsonProperty("found_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FoundBy { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("push_to_jira", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushToJira { get; set; }

        [JsonProperty("vulnerability_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<VulnerabilityId> VulnerabilityIds { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reporter { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        [JsonProperty("sla_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaStartDate { get; set; }

        [JsonProperty("sla_expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaExpirationDate { get; set; }

        [JsonProperty("cwe", NullValueHandling = NullValueHandling.Ignore)]
        public long? Cwe { get; set; }

        [JsonProperty("epss_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? EpssScore { get; set; }

        [JsonProperty("epss_percentile", NullValueHandling = NullValueHandling.Ignore)]
        public int? EpssPercentile { get; set; }

        [JsonProperty("cvssv3", NullValueHandling = NullValueHandling.Ignore)]
        public string Cvssv3 { get; set; }

        [JsonProperty("cvssv3_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cvssv3Score { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("mitigation", NullValueHandling = NullValueHandling.Ignore)]
        public string Mitigation { get; set; }

        [JsonProperty("impact", NullValueHandling = NullValueHandling.Ignore)]
        public string Impact { get; set; }

        [JsonProperty("steps_to_reproduce", NullValueHandling = NullValueHandling.Ignore)]
        public string StepsToReproduce { get; set; }

        [JsonProperty("severity_justification", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityJustification { get; set; }

        [JsonProperty("references", NullValueHandling = NullValueHandling.Ignore)]
        public string References { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("verified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Verified { get; set; }

        [JsonProperty("false_p", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FalseP { get; set; }

        [JsonProperty("duplicate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Duplicate { get; set; }

        [JsonProperty("out_of_scope", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OutOfScope { get; set; }

        [JsonProperty("risk_accepted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RiskAccepted { get; set; }

        [JsonProperty("under_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderReview { get; set; }

        [JsonProperty("under_defect_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderDefectReview { get; set; }

        [JsonProperty("is_mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMitigated { get; set; }

        [JsonProperty("numerical_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericalSeverity { get; set; }

        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public long? Line { get; set; }

        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        [JsonProperty("component_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentName { get; set; }

        [JsonProperty("component_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentVersion { get; set; }

        [JsonProperty("static_finding", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StaticFinding { get; set; }

        [JsonProperty("dynamic_finding", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicFinding { get; set; }

        [JsonProperty("unique_id_from_tool", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueIdFromTool { get; set; }

        [JsonProperty("vuln_id_from_tool", NullValueHandling = NullValueHandling.Ignore)]
        public string VulnIdFromTool { get; set; }

        [JsonProperty("sast_source_object", NullValueHandling = NullValueHandling.Ignore)]
        public string SastSourceObject { get; set; }

        [JsonProperty("sast_sink_object", NullValueHandling = NullValueHandling.Ignore)]
        public string SastSinkObject { get; set; }

        [JsonProperty("sast_source_line", NullValueHandling = NullValueHandling.Ignore)]
        public long? SastSourceLine { get; set; }

        [JsonProperty("sast_source_file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SastSourceFilePath { get; set; }

        [JsonProperty("nb_occurences", NullValueHandling = NullValueHandling.Ignore)]
        public long? NbOccurences { get; set; }

        [JsonProperty("publish_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDate { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("planned_remediation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string PlannedRemediationDate { get; set; }

        [JsonProperty("planned_remediation_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PlannedRemediationVersion { get; set; }

        [JsonProperty("effort_for_fixing", NullValueHandling = NullValueHandling.Ignore)]
        public string EffortForFixing { get; set; }

        [JsonProperty("review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewRequestedBy { get; set; }

        [JsonProperty("defect_review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectReviewRequestedBy { get; set; }

        [JsonProperty("sonarqube_issue", NullValueHandling = NullValueHandling.Ignore)]
        public int? SonarqubeIssue { get; set; }

        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Reviewers { get; set; }
    }

    public class VulnerabilityId
    {
        [JsonProperty("vulnerability_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Vulnerability_Id { get; set; }
    }




}
