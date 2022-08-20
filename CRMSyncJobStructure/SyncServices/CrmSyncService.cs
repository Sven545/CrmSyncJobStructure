using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.SyncModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncServices
{
    public class CrmSyncService : ISyncService
    {
        public ISyncProvider Provider { get; set; }
        public ISyncManager Manager { get; set; }
        public IEnumerable<SyncObjectsEnum> ObjectsForSync { get; set; }

        /// <summary>
        /// Выбор конкретного провайдера и менеджера сделан ранее, также выбран конкретный сервис авторизации для конкретного провайдера
        /// Используем абстрактную фабрику для формирования связанных объектов
        /// </summary>    
        public CrmSyncService(ISyncProvider provider, ISyncManager manager, IEnumerable<SyncObjectsEnum> objectsForSync)
        {
            Provider = provider;
            Manager = manager;
            
            ObjectsForSync = objectsForSync;
            Provider.SyncObjects = Manager.GetSyncObjects(objectsForSync);
        }

        public void Synchronize()
        {
            Provider.DoSyncObjects();
        }

        public void Authorize()
        {
            Provider.Authorize();
        }

        public GroupsEntitiesRelation GetEntitiesRelations()
        {
            return Provider.GetEntitiesRelations();
        }
    }
}
