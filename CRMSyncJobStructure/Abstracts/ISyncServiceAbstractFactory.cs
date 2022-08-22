using CRMSyncJobStructure.SyncModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Abstracts
{
    public interface ISyncServiceAbstractFactory
    {
        public ISyncService GetSyncService(IEnumerable<SyncModels.SyncObjects> objectsForSync);
    }
}
