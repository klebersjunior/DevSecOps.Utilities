using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.WebApi.Model.DefectDojo
{
	public class ProductModel
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Tags { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("prod_numeric_grade", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProdNumericGrade { get; set; }

        [JsonProperty("business_criticality", NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCriticality { get; set; }

        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string? Platform { get; set; }

        [JsonProperty("lifecycle", NullValueHandling = NullValueHandling.Ignore)]
        public string? Lifecycle { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string? Origin { get; set; }

        [JsonProperty("user_records", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserRecords { get; set; }

        [JsonProperty("revenue", NullValueHandling = NullValueHandling.Ignore)]
        public string? Revenue { get; set; }

        [JsonProperty("external_audience", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExternalAudience { get; set; }

        [JsonProperty("internet_accessible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InternetAccessible { get; set; }

        [JsonProperty("enable_product_tag_inheritance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableProductTagInheritance { get; set; }

        [JsonProperty("enable_simple_risk_acceptance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSimpleRiskAcceptance { get; set; }

        [JsonProperty("enable_full_risk_acceptance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFullRiskAcceptance { get; set; }

        [JsonProperty("disable_sla_breach_notifications", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableSlaBreachNotifications { get; set; }

        [JsonProperty("product_manager", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductManager { get; set; }

        [JsonProperty("technical_contact", NullValueHandling = NullValueHandling.Ignore)]
        public int? TechnicalContact { get; set; }

        [JsonProperty("team_manager", NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamManager { get; set; }

        [JsonProperty("prod_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProdType { get; set; }

        [JsonProperty("sla_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlaConfiguration { get; set; }

        [JsonProperty("regulations", NullValueHandling = NullValueHandling.Ignore)]
        public List<int>? Regulations { get; set; }
    }
}

