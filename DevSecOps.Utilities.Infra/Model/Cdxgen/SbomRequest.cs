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
    }
}
