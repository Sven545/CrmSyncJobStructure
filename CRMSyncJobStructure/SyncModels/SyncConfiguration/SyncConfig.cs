using CRMSyncJobStructure.SyncModels.SyncConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.SyncConfiguration
{
    public class SyncConfig
    {
        public CrmSystems Crm { get; set; }
        public bool SyncStatus { get; set; }
        public SyncRules? SyncRule { get; set; }
        public CommonSyncObjectConfiguration Domains { get; set; }
        public CommonSyncObjectConfiguration Bases { get; set; }
        public CommonSyncObjectConfiguration Rooms { get; set; }
        public CommonSyncObjectConfiguration Calendars { get; set; }
        public CommonSyncObjectConfiguration Equipments { get; set; }

    }
}
