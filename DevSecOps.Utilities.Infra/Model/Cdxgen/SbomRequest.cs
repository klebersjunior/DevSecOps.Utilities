using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.Cdxgen
{
    public class SbomRequest
    {
        public string url { get; set; }
        public string type { get; set; }
        public string multiProject { get; set; }

        public string serverUrl { get; set; }
        public string apiKey { get; set; }
        public string projectId { get; set; }
    }
}
