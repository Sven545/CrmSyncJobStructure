using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.SyncModels.SyncConfiguration;

namespace CRMSyncJobStructure.SyncModels
{
    public class ManagerYClientsParameters : ISyncManagerParameters
    {

        public SyncObjects SyncObjectType { get; set; }
        public string CompanyId { get; set; }
        public CommonSyncObjectConfiguration SyncObjectCongiguration { get; set; }
    }
}
