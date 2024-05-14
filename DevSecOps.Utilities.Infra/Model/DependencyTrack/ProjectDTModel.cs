using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.Infra.Model.DependencyTrack
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Author
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }
    }

    public class Contact
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }
    }

    public class ExternalReference
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }
    }

    public class Manufacturer
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }

        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Contact> Contacts { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("supplier", NullValueHandling = NullValueHandling.Ignore)]
        public Supplier Supplier { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Author> Authors { get; set; }
    }

    public class Metrics
    {
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }

        [JsonProperty("critical", NullValueHandling = NullValueHandling.Ignore)]
        public int? Critical { get; set; }

        [JsonProperty("high", NullValueHandling = NullValueHandling.Ignore)]
        public int? High { get; set; }

        [JsonProperty("medium", NullValueHandling = NullValueHandling.Ignore)]
        public int? Medium { get; set; }

        [JsonProperty("low", NullValueHandling = NullValueHandling.Ignore)]
        public int? Low { get; set; }

        [JsonProperty("unassigned", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unassigned { get; set; }

        [JsonProperty("vulnerabilities", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vulnerabilities { get; set; }

        [JsonProperty("vulnerableComponents", NullValueHandling = NullValueHandling.Ignore)]
        public int? VulnerableComponents { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public int? Components { get; set; }

        [JsonProperty("suppressed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Suppressed { get; set; }

        [JsonProperty("findingsTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? FindingsTotal { get; set; }

        [JsonProperty("findingsAudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? FindingsAudited { get; set; }

        [JsonProperty("findingsUnaudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? FindingsUnaudited { get; set; }

        [JsonProperty("inheritedRiskScore", NullValueHandling = NullValueHandling.Ignore)]
        public double? InheritedRiskScore { get; set; }

        [JsonProperty("policyViolationsFail", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsFail { get; set; }

        [JsonProperty("policyViolationsWarn", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsWarn { get; set; }

        [JsonProperty("policyViolationsInfo", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsInfo { get; set; }

        [JsonProperty("policyViolationsTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsTotal { get; set; }

        [JsonProperty("policyViolationsAudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsAudited { get; set; }

        [JsonProperty("policyViolationsUnaudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsUnaudited { get; set; }

        [JsonProperty("policyViolationsSecurityTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsSecurityTotal { get; set; }

        [JsonProperty("policyViolationsSecurityAudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsSecurityAudited { get; set; }

        [JsonProperty("policyViolationsSecurityUnaudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsSecurityUnaudited { get; set; }

        [JsonProperty("policyViolationsLicenseTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsLicenseTotal { get; set; }

        [JsonProperty("policyViolationsLicenseAudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsLicenseAudited { get; set; }

        [JsonProperty("policyViolationsLicenseUnaudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsLicenseUnaudited { get; set; }

        [JsonProperty("policyViolationsOperationalTotal", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsOperationalTotal { get; set; }

        [JsonProperty("policyViolationsOperationalAudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsOperationalAudited { get; set; }

        [JsonProperty("policyViolationsOperationalUnaudited", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyViolationsOperationalUnaudited { get; set; }

        [JsonProperty("firstOccurrence", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstOccurrence { get; set; }

        [JsonProperty("lastOccurrence", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastOccurrence { get; set; }
    }

    public class Property
    {
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }

        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        [JsonProperty("propertyName", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyName { get; set; }

        [JsonProperty("propertyValue", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyValue { get; set; }

        [JsonProperty("propertyType", NullValueHandling = NullValueHandling.Ignore)]
        public string PropertyType { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public class Purl
    {
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Scheme { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("qualifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Qualifiers Qualifiers { get; set; }

        [JsonProperty("subpath", NullValueHandling = NullValueHandling.Ignore)]
        public string Subpath { get; set; }

        [JsonProperty("coordinates", NullValueHandling = NullValueHandling.Ignore)]
        public string Coordinates { get; set; }
    }

    public class Qualifiers
    {
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalProp3 { get; set; }
    }

    public class ProjectDTModel
    {
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public Manufacturer Manufacturer { get; set; }

        [JsonProperty("supplier", NullValueHandling = NullValueHandling.Ignore)]
        public Supplier Supplier { get; set; }

        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("classifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Classifier { get; set; }

        [JsonProperty("cpe", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpe { get; set; }

        [JsonProperty("purl", NullValueHandling = NullValueHandling.Ignore)]
        public Purl Purl { get; set; }

        [JsonProperty("swidTagId", NullValueHandling = NullValueHandling.Ignore)]
        public string SwidTagId { get; set; }

        [JsonProperty("directDependencies", NullValueHandling = NullValueHandling.Ignore)]
        public string DirectDependencies { get; set; }

        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public string Parent { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Children { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<Property> Properties { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        [JsonProperty("lastBomImport", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastBomImport { get; set; }

        [JsonProperty("lastBomImportFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBomImportFormat { get; set; }

        [JsonProperty("lastInheritedRiskScore", NullValueHandling = NullValueHandling.Ignore)]
        public double? LastInheritedRiskScore { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("externalReferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalReference> ExternalReferences { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Version> Versions { get; set; }

        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public Metrics Metrics { get; set; }
    }

    public class Supplier
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Urls { get; set; }

        [JsonProperty("contacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Contact> Contacts { get; set; }
    }

    public class Tag
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Version
    {
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionNumber { get; set; }
    }


}

