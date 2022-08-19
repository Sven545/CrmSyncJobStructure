using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;

namespace CRMSyncJobStructure.Jobs
{/// <summary>
/// По сути является клиентом сервиса синхронизации, находится на одном уровне с контроллером для принудительной синхронизации
/// </summary>
    public class SyncJob
    {
        public ISyncService SyncService { get; set; }
        /// <summary>
        ///  В Startup решаем, какой сервис синхронизации будет работать 
        ///  Там же выбираем конкретного менеджера и провайдера(+сервис авторизации для конкретного провайдера)
        ///  НАпример будет AbstractCrmFactory с методами GetCrmService,
        /// </summary>
        public SyncJob(ISyncService syncService)
        {
            SyncService = syncService;
        }
        public void RunAsync()// Запускается по таймеру
        {
            SyncService.Synchronize();
        }
    }
}
