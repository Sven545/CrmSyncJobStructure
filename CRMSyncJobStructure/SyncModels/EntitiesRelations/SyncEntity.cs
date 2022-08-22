using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.EntitiesRelations
{
    public class SyncEntity
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
    }
}
