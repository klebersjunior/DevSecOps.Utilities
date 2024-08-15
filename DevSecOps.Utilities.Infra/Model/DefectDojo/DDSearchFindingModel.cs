using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.DefectDojo
{

    public class AcceptedRisk
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("recommendation", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommendation { get; set; }

        [JsonProperty("decision", NullValueHandling = NullValueHandling.Ignore)]
        public string Decision { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("recommendation_details", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendationDetails { get; set; }

        [JsonProperty("decision_details", NullValueHandling = NullValueHandling.Ignore)]
        public string DecisionDetails { get; set; }

        [JsonProperty("accepted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptedBy { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("expiration_date_warned", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateWarned { get; set; }

        [JsonProperty("expiration_date_handled", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateHandled { get; set; }

        [JsonProperty("reactivate_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReactivateExpired { get; set; }

        [JsonProperty("restart_sla_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartSlaExpired { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public int? Owner { get; set; }

        [JsonProperty("accepted_findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AcceptedFindings { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Notes { get; set; }
    }

    public class AdditionalProp1
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("session_management", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionManagement { get; set; }

        [JsonProperty("encryption_crypto", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionCrypto { get; set; }

        [JsonProperty("configuration_management", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationManagement { get; set; }

        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public string Authentication { get; set; }

        [JsonProperty("authorization_and_access_control", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationAndAccessControl { get; set; }

        [JsonProperty("data_input_sanitization_validation", NullValueHandling = NullValueHandling.Ignore)]
        public string DataInputSanitizationValidation { get; set; }

        [JsonProperty("sensitive_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveData { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public string Other { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("session_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SessionIssues { get; set; }

        [JsonProperty("crypto_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> CryptoIssues { get; set; }

        [JsonProperty("config_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ConfigIssues { get; set; }

        [JsonProperty("auth_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthIssues { get; set; }

        [JsonProperty("author_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthorIssues { get; set; }

        [JsonProperty("data_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DataIssues { get; set; }

        [JsonProperty("sensitive_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SensitiveIssues { get; set; }

        [JsonProperty("other_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> OtherIssues { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("jira_issue", NullValueHandling = NullValueHandling.Ignore)]
        public JiraIssue JiraIssue { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("editor", NullValueHandling = NullValueHandling.Ignore)]
        public Editor Editor { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("note_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteType NoteType { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Edited { get; set; }

        [JsonProperty("edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EditTime { get; set; }

        [JsonProperty("recommendation", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommendation { get; set; }

        [JsonProperty("decision", NullValueHandling = NullValueHandling.Ignore)]
        public string Decision { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        [JsonProperty("recommendation_details", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendationDetails { get; set; }

        [JsonProperty("decision_details", NullValueHandling = NullValueHandling.Ignore)]
        public string DecisionDetails { get; set; }

        [JsonProperty("accepted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptedBy { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("expiration_date_warned", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateWarned { get; set; }

        [JsonProperty("expiration_date_handled", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateHandled { get; set; }

        [JsonProperty("reactivate_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReactivateExpired { get; set; }

        [JsonProperty("restart_sla_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartSlaExpired { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public int? Owner { get; set; }

        [JsonProperty("accepted_findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AcceptedFindings { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Notes { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("static_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StaticTool { get; set; }

        [JsonProperty("dynamic_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicTool { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("test_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTypeName { get; set; }

        [JsonProperty("finding_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingGroup> FindingGroups { get; set; }

        [JsonProperty("scan_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanType { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetEnd { get; set; }

        [JsonProperty("estimated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedTime { get; set; }

        [JsonProperty("actual_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualTime { get; set; }

        [JsonProperty("percent_complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? PercentComplete { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lead { get; set; }

        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; }

        [JsonProperty("api_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApiScanConfiguration { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<File> Files { get; set; }

        [JsonProperty("test_import_finding_action_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestImportFindingActionSet> TestImportFindingActionSet { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [JsonProperty("import_settings", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportSettings { get; set; }

        [JsonProperty("findings_affected", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FindingsAffected { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("userinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Userinfo { get; set; }

        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public long? Port { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        [JsonProperty("fragment", NullValueHandling = NullValueHandling.Ignore)]
        public string Fragment { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; }

        [JsonProperty("endpoint_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EndpointParams { get; set; }

        [JsonProperty("findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Findings { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty("request_response", NullValueHandling = NullValueHandling.Ignore)]
        public RequestResponse RequestResponse { get; set; }

        [JsonProperty("accepted_risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AcceptedRisk> AcceptedRisks { get; set; }

        [JsonProperty("push_to_jira", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushToJira { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [JsonProperty("sla_days_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaDaysRemaining { get; set; }

        [JsonProperty("finding_meta", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingMetum> FindingMeta { get; set; }

        [JsonProperty("related_fields", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedFields RelatedFields { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("display_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayStatus { get; set; }

        [JsonProperty("vulnerability_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<VulnerabilityId> VulnerabilityIds { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reporter { get; set; }

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
        public double? Cvssv3Score { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

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

        [JsonProperty("last_status_update", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastStatusUpdate { get; set; }

        [JsonProperty("under_defect_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderDefectReview { get; set; }

        [JsonProperty("is_mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMitigated { get; set; }

        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThreadId { get; set; }

        [JsonProperty("mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Mitigated { get; set; }

        [JsonProperty("numerical_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericalSeverity { get; set; }

        [JsonProperty("last_reviewed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastReviewed { get; set; }

        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        [JsonProperty("hash_code", NullValueHandling = NullValueHandling.Ignore)]
        public string HashCode { get; set; }

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

        [JsonProperty("scanner_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScannerConfidence { get; set; }

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

        [JsonProperty("duplicate_finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicateFinding { get; set; }

        [JsonProperty("review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewRequestedBy { get; set; }

        [JsonProperty("defect_review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectReviewRequestedBy { get; set; }

        [JsonProperty("mitigated_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? MitigatedBy { get; set; }

        [JsonProperty("last_reviewed_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastReviewedBy { get; set; }

        [JsonProperty("sonarqube_issue", NullValueHandling = NullValueHandling.Ignore)]
        public int? SonarqubeIssue { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Endpoints { get; set; }

        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Reviewers { get; set; }

        [JsonProperty("found_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FoundBy { get; set; }
    }

    public class AdditionalProp2
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("session_management", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionManagement { get; set; }

        [JsonProperty("encryption_crypto", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionCrypto { get; set; }

        [JsonProperty("configuration_management", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationManagement { get; set; }

        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public string Authentication { get; set; }

        [JsonProperty("authorization_and_access_control", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationAndAccessControl { get; set; }

        [JsonProperty("data_input_sanitization_validation", NullValueHandling = NullValueHandling.Ignore)]
        public string DataInputSanitizationValidation { get; set; }

        [JsonProperty("sensitive_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveData { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public string Other { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("session_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SessionIssues { get; set; }

        [JsonProperty("crypto_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> CryptoIssues { get; set; }

        [JsonProperty("config_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ConfigIssues { get; set; }

        [JsonProperty("auth_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthIssues { get; set; }

        [JsonProperty("author_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthorIssues { get; set; }

        [JsonProperty("data_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DataIssues { get; set; }

        [JsonProperty("sensitive_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SensitiveIssues { get; set; }

        [JsonProperty("other_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> OtherIssues { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("jira_issue", NullValueHandling = NullValueHandling.Ignore)]
        public JiraIssue JiraIssue { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("editor", NullValueHandling = NullValueHandling.Ignore)]
        public Editor Editor { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("note_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteType NoteType { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Edited { get; set; }

        [JsonProperty("edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EditTime { get; set; }

        [JsonProperty("recommendation", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommendation { get; set; }

        [JsonProperty("decision", NullValueHandling = NullValueHandling.Ignore)]
        public string Decision { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        [JsonProperty("recommendation_details", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendationDetails { get; set; }

        [JsonProperty("decision_details", NullValueHandling = NullValueHandling.Ignore)]
        public string DecisionDetails { get; set; }

        [JsonProperty("accepted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptedBy { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("expiration_date_warned", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateWarned { get; set; }

        [JsonProperty("expiration_date_handled", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateHandled { get; set; }

        [JsonProperty("reactivate_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReactivateExpired { get; set; }

        [JsonProperty("restart_sla_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartSlaExpired { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public int? Owner { get; set; }

        [JsonProperty("accepted_findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AcceptedFindings { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Notes { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("static_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StaticTool { get; set; }

        [JsonProperty("dynamic_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicTool { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("test_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTypeName { get; set; }

        [JsonProperty("finding_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingGroup> FindingGroups { get; set; }

        [JsonProperty("scan_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanType { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetEnd { get; set; }

        [JsonProperty("estimated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedTime { get; set; }

        [JsonProperty("actual_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualTime { get; set; }

        [JsonProperty("percent_complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? PercentComplete { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lead { get; set; }

        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; }

        [JsonProperty("api_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApiScanConfiguration { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<File> Files { get; set; }

        [JsonProperty("test_import_finding_action_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestImportFindingActionSet> TestImportFindingActionSet { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [JsonProperty("import_settings", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportSettings { get; set; }

        [JsonProperty("findings_affected", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FindingsAffected { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("userinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Userinfo { get; set; }

        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public long? Port { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        [JsonProperty("fragment", NullValueHandling = NullValueHandling.Ignore)]
        public string Fragment { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; }

        [JsonProperty("endpoint_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EndpointParams { get; set; }

        [JsonProperty("findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Findings { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty("request_response", NullValueHandling = NullValueHandling.Ignore)]
        public RequestResponse RequestResponse { get; set; }

        [JsonProperty("accepted_risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AcceptedRisk> AcceptedRisks { get; set; }

        [JsonProperty("push_to_jira", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushToJira { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [JsonProperty("sla_days_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaDaysRemaining { get; set; }

        [JsonProperty("finding_meta", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingMetum> FindingMeta { get; set; }

        [JsonProperty("related_fields", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedFields RelatedFields { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("display_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayStatus { get; set; }

        [JsonProperty("vulnerability_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<VulnerabilityId> VulnerabilityIds { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reporter { get; set; }

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
        public double? Cvssv3Score { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

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

        [JsonProperty("last_status_update", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastStatusUpdate { get; set; }

        [JsonProperty("under_defect_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderDefectReview { get; set; }

        [JsonProperty("is_mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMitigated { get; set; }

        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThreadId { get; set; }

        [JsonProperty("mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Mitigated { get; set; }

        [JsonProperty("numerical_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericalSeverity { get; set; }

        [JsonProperty("last_reviewed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastReviewed { get; set; }

        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        [JsonProperty("hash_code", NullValueHandling = NullValueHandling.Ignore)]
        public string HashCode { get; set; }

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

        [JsonProperty("scanner_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScannerConfidence { get; set; }

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

        [JsonProperty("duplicate_finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicateFinding { get; set; }

        [JsonProperty("review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewRequestedBy { get; set; }

        [JsonProperty("defect_review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectReviewRequestedBy { get; set; }

        [JsonProperty("mitigated_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? MitigatedBy { get; set; }

        [JsonProperty("last_reviewed_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastReviewedBy { get; set; }

        [JsonProperty("sonarqube_issue", NullValueHandling = NullValueHandling.Ignore)]
        public int? SonarqubeIssue { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Endpoints { get; set; }

        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Reviewers { get; set; }

        [JsonProperty("found_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FoundBy { get; set; }
    }

    public class AdditionalProp3
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("session_management", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionManagement { get; set; }

        [JsonProperty("encryption_crypto", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptionCrypto { get; set; }

        [JsonProperty("configuration_management", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationManagement { get; set; }

        [JsonProperty("authentication", NullValueHandling = NullValueHandling.Ignore)]
        public string Authentication { get; set; }

        [JsonProperty("authorization_and_access_control", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationAndAccessControl { get; set; }

        [JsonProperty("data_input_sanitization_validation", NullValueHandling = NullValueHandling.Ignore)]
        public string DataInputSanitizationValidation { get; set; }

        [JsonProperty("sensitive_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SensitiveData { get; set; }

        [JsonProperty("other", NullValueHandling = NullValueHandling.Ignore)]
        public string Other { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("session_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SessionIssues { get; set; }

        [JsonProperty("crypto_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> CryptoIssues { get; set; }

        [JsonProperty("config_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ConfigIssues { get; set; }

        [JsonProperty("auth_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthIssues { get; set; }

        [JsonProperty("author_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AuthorIssues { get; set; }

        [JsonProperty("data_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> DataIssues { get; set; }

        [JsonProperty("sensitive_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> SensitiveIssues { get; set; }

        [JsonProperty("other_issues", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> OtherIssues { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("jira_issue", NullValueHandling = NullValueHandling.Ignore)]
        public JiraIssue JiraIssue { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("editor", NullValueHandling = NullValueHandling.Ignore)]
        public Editor Editor { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("note_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteType NoteType { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Edited { get; set; }

        [JsonProperty("edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EditTime { get; set; }

        [JsonProperty("recommendation", NullValueHandling = NullValueHandling.Ignore)]
        public string Recommendation { get; set; }

        [JsonProperty("decision", NullValueHandling = NullValueHandling.Ignore)]
        public string Decision { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        [JsonProperty("recommendation_details", NullValueHandling = NullValueHandling.Ignore)]
        public string RecommendationDetails { get; set; }

        [JsonProperty("decision_details", NullValueHandling = NullValueHandling.Ignore)]
        public string DecisionDetails { get; set; }

        [JsonProperty("accepted_by", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptedBy { get; set; }

        [JsonProperty("expiration_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDate { get; set; }

        [JsonProperty("expiration_date_warned", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateWarned { get; set; }

        [JsonProperty("expiration_date_handled", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpirationDateHandled { get; set; }

        [JsonProperty("reactivate_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReactivateExpired { get; set; }

        [JsonProperty("restart_sla_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartSlaExpired { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public int? Owner { get; set; }

        [JsonProperty("accepted_findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AcceptedFindings { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Notes { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("static_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StaticTool { get; set; }

        [JsonProperty("dynamic_tool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicTool { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("test_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestTypeName { get; set; }

        [JsonProperty("finding_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingGroup> FindingGroups { get; set; }

        [JsonProperty("scan_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScanType { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? TargetEnd { get; set; }

        [JsonProperty("estimated_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EstimatedTime { get; set; }

        [JsonProperty("actual_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualTime { get; set; }

        [JsonProperty("percent_complete", NullValueHandling = NullValueHandling.Ignore)]
        public long? PercentComplete { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public int? Lead { get; set; }

        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; }

        [JsonProperty("api_scan_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApiScanConfiguration { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<File> Files { get; set; }

        [JsonProperty("test_import_finding_action_set", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestImportFindingActionSet> TestImportFindingActionSet { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [JsonProperty("import_settings", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportSettings { get; set; }

        [JsonProperty("findings_affected", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FindingsAffected { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }

        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        [JsonProperty("userinfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Userinfo { get; set; }

        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public long? Port { get; set; }

        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        [JsonProperty("fragment", NullValueHandling = NullValueHandling.Ignore)]
        public string Fragment { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public int? Product { get; set; }

        [JsonProperty("endpoint_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> EndpointParams { get; set; }

        [JsonProperty("findings", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Findings { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        [JsonProperty("request_response", NullValueHandling = NullValueHandling.Ignore)]
        public RequestResponse RequestResponse { get; set; }

        [JsonProperty("accepted_risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AcceptedRisk> AcceptedRisks { get; set; }

        [JsonProperty("push_to_jira", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushToJira { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [JsonProperty("sla_days_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaDaysRemaining { get; set; }

        [JsonProperty("finding_meta", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingMetum> FindingMeta { get; set; }

        [JsonProperty("related_fields", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedFields RelatedFields { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("display_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayStatus { get; set; }

        [JsonProperty("vulnerability_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<VulnerabilityId> VulnerabilityIds { get; set; }

        [JsonProperty("reporter", NullValueHandling = NullValueHandling.Ignore)]
        public int? Reporter { get; set; }

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
        public double? Cvssv3Score { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

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

        [JsonProperty("last_status_update", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastStatusUpdate { get; set; }

        [JsonProperty("under_defect_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderDefectReview { get; set; }

        [JsonProperty("is_mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMitigated { get; set; }

        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThreadId { get; set; }

        [JsonProperty("mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Mitigated { get; set; }

        [JsonProperty("numerical_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericalSeverity { get; set; }

        [JsonProperty("last_reviewed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastReviewed { get; set; }

        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        [JsonProperty("hash_code", NullValueHandling = NullValueHandling.Ignore)]
        public string HashCode { get; set; }

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

        [JsonProperty("scanner_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScannerConfidence { get; set; }

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

        [JsonProperty("duplicate_finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicateFinding { get; set; }

        [JsonProperty("review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewRequestedBy { get; set; }

        [JsonProperty("defect_review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectReviewRequestedBy { get; set; }

        [JsonProperty("mitigated_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? MitigatedBy { get; set; }

        [JsonProperty("last_reviewed_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastReviewedBy { get; set; }

        [JsonProperty("sonarqube_issue", NullValueHandling = NullValueHandling.Ignore)]
        public int? SonarqubeIssue { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Endpoints { get; set; }

        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Reviewers { get; set; }

        [JsonProperty("found_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FoundBy { get; set; }
    }

    public class AuthIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class Author
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
    }

    public class AuthorIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class ConfigIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class CryptoIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class CurrentEditor
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
    }

    public class DataIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class DefectReviewRequestedBy
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class DuplicateFinding
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }
    }

    public class Editor
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }
    }

    public class Endpoints
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class EndpointSet
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class Engagement
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public Product Product { get; set; }

        [JsonProperty("target_start", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetStart { get; set; }

        [JsonProperty("target_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetEnd { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("engagement_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngagementType { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Updated { get; set; }
    }

    public class Environment
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class File
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string FileProperty { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class FindingGroup
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("jira_issue", NullValueHandling = NullValueHandling.Ignore)]
        public JiraIssue JiraIssue { get; set; }
    }

    public class FindingGroupSet
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class FindingMetum
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public class FindingsAffected
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }
    }

    public class FoundBy
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class History
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("current_editor", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentEditor CurrentEditor { get; set; }

        [JsonProperty("note_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteType NoteType { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }
    }

    public class Jira
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("jira_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraId { get; set; }

        [JsonProperty("jira_key", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraKey { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("jira_project", NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraProject { get; set; }

        [JsonProperty("finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finding { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("finding_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? FindingGroup { get; set; }
    }

    public class JiraIssue
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("jira_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraId { get; set; }

        [JsonProperty("jira_key", NullValueHandling = NullValueHandling.Ignore)]
        public string JiraKey { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("jira_project", NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraProject { get; set; }

        [JsonProperty("finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finding { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public int? Engagement { get; set; }

        [JsonProperty("finding_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? FindingGroup { get; set; }
    }

    public class LastReviewedBy
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class MitigatedBy
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class Note
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [JsonProperty("editor", NullValueHandling = NullValueHandling.Ignore)]
        public Editor Editor { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public List<History> History { get; set; }

        [JsonProperty("note_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteType NoteType { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public string Entry { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Edited { get; set; }

        [JsonProperty("edit_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EditTime { get; set; }

        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class NoteType
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("is_single", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSingle { get; set; }

        [JsonProperty("is_active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActive { get; set; }

        [JsonProperty("is_mandatory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMandatory { get; set; }
    }

    public class OtherIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    

    public class ProdType
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Product
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("prod_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProdType ProdType { get; set; }
    }

    public class RelatedFields
    {
        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public Test Test { get; set; }

        [JsonProperty("jira", NullValueHandling = NullValueHandling.Ignore)]
        public Jira Jira { get; set; }
    }

    public class Reporter
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class ReqResp
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }
    }

    public class RequestResponse
    {
        [JsonProperty("req_resp", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReqResp> ReqResp { get; set; }
    }

    public class Result
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("request_response", NullValueHandling = NullValueHandling.Ignore)]
        public RequestResponse RequestResponse { get; set; }

        [JsonProperty("accepted_risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<AcceptedRisk> AcceptedRisks { get; set; }

        [JsonProperty("push_to_jira", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PushToJira { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [JsonProperty("sla_days_remaining", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaDaysRemaining { get; set; }

        [JsonProperty("finding_meta", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingMetum> FindingMeta { get; set; }

        [JsonProperty("related_fields", NullValueHandling = NullValueHandling.Ignore)]
        public RelatedFields RelatedFields { get; set; }

        [JsonProperty("jira_creation", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraCreation { get; set; }

        [JsonProperty("jira_change", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? JiraChange { get; set; }

        [JsonProperty("display_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayStatus { get; set; }

        [JsonProperty("finding_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<FindingGroup> FindingGroups { get; set; }

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
        public double? Cvssv3Score { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

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

        [JsonProperty("last_status_update", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastStatusUpdate { get; set; }

        [JsonProperty("under_defect_review", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnderDefectReview { get; set; }

        [JsonProperty("is_mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMitigated { get; set; }

        [JsonProperty("thread_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThreadId { get; set; }

        [JsonProperty("mitigated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Mitigated { get; set; }

        [JsonProperty("numerical_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string NumericalSeverity { get; set; }

        [JsonProperty("last_reviewed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastReviewed { get; set; }

        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        [JsonProperty("payload", NullValueHandling = NullValueHandling.Ignore)]
        public string Payload { get; set; }

        [JsonProperty("hash_code", NullValueHandling = NullValueHandling.Ignore)]
        public string HashCode { get; set; }

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

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("scanner_confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScannerConfidence { get; set; }

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

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public int? Test { get; set; }

        [JsonProperty("duplicate_finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? DuplicateFinding { get; set; }

        [JsonProperty("review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewRequestedBy { get; set; }

        [JsonProperty("defect_review_requested_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefectReviewRequestedBy { get; set; }

        [JsonProperty("mitigated_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? MitigatedBy { get; set; }

        [JsonProperty("last_reviewed_by", NullValueHandling = NullValueHandling.Ignore)]
        public int? LastReviewedBy { get; set; }

        [JsonProperty("sonarqube_issue", NullValueHandling = NullValueHandling.Ignore)]
        public int? SonarqubeIssue { get; set; }

        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Endpoints { get; set; }

        [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Reviewers { get; set; }

        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Note> Notes { get; set; }

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Files { get; set; }

        [JsonProperty("found_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> FoundBy { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }
    }

    public class Reviewers
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class ReviewRequestedBy
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class RiskAcceptanceSet
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class DDSearchFindingModel
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public string Next { get; set; }

        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public string Previous { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<Result> Results { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }
    }

    public class SensitiveIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class SessionIssues
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class SonarqubeIssue
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class Test
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public TestType TestType { get; set; }

        [JsonProperty("engagement", NullValueHandling = NullValueHandling.Ignore)]
        public Engagement Engagement { get; set; }

        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public Environment Environment { get; set; }

        [JsonProperty("branch_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchTag { get; set; }

        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        [JsonProperty("commit_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitHash { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class TestImportFindingActionSet
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("test_import", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestImport { get; set; }

        [JsonProperty("finding", NullValueHandling = NullValueHandling.Ignore)]
        public int? Finding { get; set; }
    }

    public class TestImportSet
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp1 AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp2 AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProp3 AdditionalProp3 { get; set; }
    }

    public class TestType
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }



}
