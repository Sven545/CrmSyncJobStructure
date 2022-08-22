using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.EntitiesRelations
{
    public class EntitiesRelation
    {
        public SyncEntity[] Crm { get; set; }
        public SyncEntity[] Mb { get; set; }
    }
}
