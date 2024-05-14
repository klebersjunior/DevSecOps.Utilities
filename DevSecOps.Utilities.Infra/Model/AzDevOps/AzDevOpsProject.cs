using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.AzDevOps
{
    
    public class AzDevOpsProjectResult
    {
        public int count { get; set; }
        public List<AzDevOpsProject> value { get; set; }
    }

    public class AzDevOpsProject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string state { get; set; }
        public int revision { get; set; }
        public string visibility { get; set; }
        public DateTime lastUpdateTime { get; set; }
        public string description { get; set; }
    }


}
