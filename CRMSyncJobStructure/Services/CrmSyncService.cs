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
        public ISyncManager Manager { get ; set; }

        /// <summary>
        /// Выбор конкретного провайдера и менеджера сделан ранее, также выбран конкретный сервис авторизации для конкретного провайдера
        /// Используем абстрактную фабрику для формирования связанных объектов
        /// </summary>    
        public CrmSyncService(ISyncProvider provider,ISyncManager manager)
        {
            Provider = provider;
            Manager = manager;
            Provider.SyncObjects= Manager.GetSyncObjects();
            
        }

        public void Synchronize()
        {
            Provider.DoSyncObjects();
        }
    }
}
