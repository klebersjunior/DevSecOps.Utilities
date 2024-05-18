using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSecOps.Utilities.Infra.Model.DefectDojo
{
    public class DDCloseFindingRequestModel
    {
        public bool is_mitigated { get; set; }
        public DateTime mitigated { get; set; }
        public bool false_p { get; set; }
        public bool out_of_scope { get; set; }
        public bool duplicate { get; set; }
    }
}
