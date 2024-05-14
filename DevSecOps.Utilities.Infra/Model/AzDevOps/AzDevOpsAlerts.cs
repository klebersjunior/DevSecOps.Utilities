using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.AzDevOps
{
    
    public class AdditionalProperties
    {
        public string cveId { get; set; }
        public string advisoryId { get; set; }
    }

    public class LogicalLocation
    {
        public string fullyQualifiedName { get; set; }
        public string kind { get; set; }
    }

    public class PhysicalLocation
    {
        public VersionControl versionControl { get; set; }
        public string filePath { get; set; }
        public Region region { get; set; }
    }

    public class Region
    {
        public int lineStart { get; set; }
        public int lineEnd { get; set; }
        public int columnStart { get; set; }
        public int columnEnd { get; set; }
    }

    public class AzDevOpsAlertsResult
    {
        public int count { get; set; }
        public List<AzDevOpsAlerts> value { get; set; }
    }

    public class Rule
    {
        public string opaqueId { get; set; }
        public string friendlyName { get; set; }
        public string description { get; set; }
        public string resources { get; set; }
        public string helpMessage { get; set; }
        public List<string> tags { get; set; }
        public AdditionalProperties additionalProperties { get; set; }
    }

    public class Tool
    {
        public string name { get; set; }
        public List<Rule> rules { get; set; }
    }

    public class AzDevOpsAlerts
    {
        public int alertId { get; set; }
        public string severity { get; set; }
        public string title { get; set; }
        public List<Tool> tools { get; set; }
        public object dismissal { get; set; }
        public string repositoryUrl { get; set; }
        public string gitRef { get; set; }
        public string alertType { get; set; }
        public DateTime firstSeenDate { get; set; }
        public DateTime lastSeenDate { get; set; }
        public object fixedDate { get; set; }
        public DateTime? introducedDate { get; set; }
        public string state { get; set; }
        public List<PhysicalLocation> physicalLocations { get; set; }
        public List<LogicalLocation> logicalLocations { get; set; }
        public string truncatedSecret { get; set; }
        public string confidence { get; set; }
    }

    public class VersionControl
    {
        public string commitHash { get; set; }
        public string itemUrl { get; set; }
    }


}
