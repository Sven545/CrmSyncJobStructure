using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.SyncObjects;
using CRMSyncJobStructure.SyncModels;

namespace CRMSyncJobStructure.SyncManagers
{
    /// <summary>
    /// Конкретный менеджер выбора объектов синхронизации для YClients
    /// </summary>
    public class YClientsSyncManager : ISyncManager
    {
        private IEnumerable<SyncObjectsEnum> ObjectsForSync { get; }
        /// <summary>
        /// В конструкторе передаем объект, на основании которого будет сформирован список объектов синхронизации
        /// Возможно при болле глубокой логике синхронизации заменим на отдельный класс с параметрами
        /// </summary>       
        public YClientsSyncManager()
        {
           // ObjectsForSync = objectsForSync;
        }
        /// <summary>
        /// Логика выбора объектов синхронизации
        /// Если передавать сюда объект с боллее подробной 
        /// </summary>        
        public IEnumerable<ISyncObject> GetSyncObjects(IEnumerable<SyncObjectsEnum> objectsForSync)
        {

            List<ISyncObject> syncObjects = new List<ISyncObject>();
            syncObjects.Add(new CalendarYClienstSyncObject());
            syncObjects.Add(new EquipmentYClienstSyncObject());
            return syncObjects;
        }
       
    }
}
