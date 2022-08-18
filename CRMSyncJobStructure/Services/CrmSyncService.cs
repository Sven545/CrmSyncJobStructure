using CRMSyncJobStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Services
{
    public class CrmSyncService:ISyncService
    {
        public ISyncProvider Provider { get; set; }
        public CrmSyncService(ISyncProvider provider)// Выбор конкретного провайдера для синхронизации сделан ранее
        {
            Provider = provider;
        }

        public void SyncRoomAsync()
        {
            Provider.DoSyncObjects();
        }
    }
}
