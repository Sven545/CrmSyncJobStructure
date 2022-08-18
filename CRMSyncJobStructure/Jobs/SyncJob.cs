using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;

namespace CRMSyncJobStructure.Jobs
{
    public class SyncJob
    {
        public ISyncService SyncService { get; set; }
        public SyncJob(ISyncService crmSyncService)// В Startup решаем, какой сервис синхронизации будет работать 
        {
            SyncService = crmSyncService;
        }
        public void RunAsync()// Запускается по таймеру
        {
            SyncService.SyncRoomAsync();
        }
    }
}
