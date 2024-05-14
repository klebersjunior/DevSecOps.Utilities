using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.AzDevOps
{

    

    public class AzDevOpsRepositoriesResult
    {
        public List<AzDevOpsRepositories> value { get; set; }
        public int count { get; set; }
    }

    public class AzDevOpsRepositories
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public AzDevOpsProject project { get; set; }
        public string defaultBranch { get; set; }
        public int size { get; set; }
        public string remoteUrl { get; set; }
        public string sshUrl { get; set; }
        public string webUrl { get; set; }
        public bool isDisabled { get; set; }
        public bool isInMaintenance { get; set; }
    }


}
