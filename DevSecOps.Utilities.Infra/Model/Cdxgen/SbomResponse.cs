using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.Cdxgen
{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Author
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Component
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("purl", NullValueHandling = NullValueHandling.Ignore)]
        public string Purl { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("bom-ref", NullValueHandling = NullValueHandling.Ignore)]
        public string BomRef { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        [JsonProperty("hashes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Hash> Hashes { get; set; }

        [JsonProperty("externalReferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalReference> ExternalReferences { get; set; }

        [JsonProperty("evidence", NullValueHandling = NullValueHandling.Ignore)]
        public Evidence Evidence { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<Property> Properties { get; set; }
    }

    public class Component2
    {
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public string Group { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("purl", NullValueHandling = NullValueHandling.Ignore)]
        public string Purl { get; set; }

        [JsonProperty("bom-ref", NullValueHandling = NullValueHandling.Ignore)]
        public string BomRef { get; set; }
    }

    public class Dependency
    {
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        [JsonProperty("dependsOn", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DependsOn { get; set; }
    }

    public class Evidence
    {
        [JsonProperty("identity", NullValueHandling = NullValueHandling.Ignore)]
        public Identity Identity { get; set; }

        [JsonProperty("occurrences", NullValueHandling = NullValueHandling.Ignore)]
        public List<Occurrence> Occurrences { get; set; }
    }

    public class ExternalReference
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public class Hash
    {
        [JsonProperty("alg", NullValueHandling = NullValueHandling.Ignore)]
        public string Alg { get; set; }

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }
    }

    public class Identity
    {
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int Confidence { get; set; }

        [JsonProperty("methods", NullValueHandling = NullValueHandling.Ignore)]
        public List<Method> Methods { get; set; }
    }

    public class Lifecycle
    {
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Timestamp { get; set; }

        [JsonProperty("tools", NullValueHandling = NullValueHandling.Ignore)]
        public Tools Tools { get; set; }

        [JsonProperty("authors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Author> Authors { get; set; }

        [JsonProperty("lifecycles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Lifecycle> Lifecycles { get; set; }

        [JsonProperty("component", NullValueHandling = NullValueHandling.Ignore)]
        public Component Component { get; set; }
    }

    public class Method
    {
        [JsonProperty("technique", NullValueHandling = NullValueHandling.Ignore)]
        public string Technique { get; set; }

        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public int Confidence { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public class Occurrence
    {
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }
    }

    public class Property
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }

    public class SbomResponse
    {
        [JsonProperty("bomFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string BomFormat { get; set; }

        [JsonProperty("specVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecVersion { get; set; }

        [JsonProperty("serialNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public int Version { get; set; }

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }

        [JsonProperty("dependencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dependency> Dependencies { get; set; }
    }

    public class Tools
    {
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Component> Components { get; set; }
    }


}
