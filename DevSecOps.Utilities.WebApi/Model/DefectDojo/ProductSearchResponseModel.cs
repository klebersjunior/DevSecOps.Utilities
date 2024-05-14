using System;
using Newtonsoft.Json;

namespace DevSecOps.Utilities.WebApi.Model.DefectDojo
{

    public class Prefetch
    {
    }

    

    public class ProductSearchResponseModel
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }

        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public object Next { get; set; }

        [JsonProperty("previous", NullValueHandling = NullValueHandling.Ignore)]
        public object Previous { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductModel> Results { get; set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public Prefetch Prefetch { get; set; }
    }


}

