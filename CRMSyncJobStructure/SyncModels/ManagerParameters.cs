using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels
{
    public class ManagerParameters
    {
        public SyncObjects SyncObject { get; set; }
        public SyncRules SyncRule { get; set; }
    }
}
