
using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.Infra.Model.Trufflehog
{

    public class Data
    {
        [JsonProperty("Git")]
        public Git Git;
    }

    public class ExtraData
    {
        [JsonProperty("account_type")]
        public string AccountType;

        [JsonProperty("rotation_guide")]
        public string RotationGuide;

        [JsonProperty("scopes")]
        public string Scopes;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("username")]
        public string Username;

        [JsonProperty("version")]
        public string Version;
    }

    public class Git
    {
        [JsonProperty("commit")]
        public string Commit;

        [JsonProperty("file")]
        public string File;

        [JsonProperty("email")]
        public string Email;

        [JsonProperty("repository")]
        public string Repository;

        [JsonProperty("timestamp")]
        public string Timestamp;

        [JsonProperty("line")]
        public int Line;
    }

    public class TrufflehogResponseModel
    {
        [JsonProperty("SourceMetadata")]
        public SourceMetadata SourceMetadata;

        [JsonProperty("SourceID")]
        public int SourceID;

        [JsonProperty("SourceType")]
        public int SourceType;

        [JsonProperty("SourceName")]
        public string SourceName;

        [JsonProperty("DetectorType")]
        public int DetectorType;

        [JsonProperty("DetectorName")]
        public string DetectorName;

        [JsonProperty("DecoderName")]
        public string DecoderName;

        [JsonProperty("Verified")]
        public bool Verified;

        [JsonProperty("Raw")]
        public string Raw;

        [JsonProperty("RawV2")]
        public string RawV2;

        [JsonProperty("Redacted")]
        public string Redacted;

        [JsonProperty("ExtraData")]
        public ExtraData ExtraData;

        [JsonProperty("StructuredData")]
        public object StructuredData;
    }

    public class SourceMetadata
    {
        [JsonProperty("Data")]
        public Data Data;
    }

}