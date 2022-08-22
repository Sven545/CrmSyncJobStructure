using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.SyncConfiguration
{
    public class CommonSyncObjectConfiguration
    {
        
        public bool SyncStatus { get; set; }
        public string ParentIdMusBooking { get; set; }
        public string ParentIdCrm { get; set; }
        public SyncRules CommonSyncRule { get; set; }
        public SyncObjectParameters[] SyncObjects { get; set; }
    }
}
