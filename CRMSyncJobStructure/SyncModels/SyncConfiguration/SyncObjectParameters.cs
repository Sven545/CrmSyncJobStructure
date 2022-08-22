using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.SyncConfiguration
{
    public class SyncObjectParameters
    {
        public string IdMusBooking { get; set; }
        public string IdCrm { get; set; }
        public bool SyncStatus { get; set; }
        public SyncRules SyncRule { get; set; }
    }
}
