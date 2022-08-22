using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.SyncObjects;
using CRMSyncJobStructure.SyncModels;

namespace CRMSyncJobStructure.SyncManagers
{
    /// <summary>
    /// Конкретный менеджер выбора объектов синхронизации для YClients
    /// </summary>
    public class YClientsSyncManager : ISyncManager
    {
        private IEnumerable<ManagerParameters> SyncParameters { get; }
        /// <summary>
        /// В конструкторе передаем объект, на основании которого будет сформирован список объектов синхронизации
        /// Возможно при болле глубокой логике синхронизации заменим на отдельный класс с параметрами
        /// </summary>       
        public YClientsSyncManager(IEnumerable<ManagerParameters> parameters)
        {
            SyncParameters = parameters;
        }
        /// <summary>
        /// Логика выбора объектов синхронизации
        /// Пока игнорируем правила SyncRules
        /// </summary>        
        public IEnumerable<ISyncObject> GetSyncObjects()
        {

            List<ISyncObject> syncObjects = new List<ISyncObject>();
            foreach(var parameter in SyncParameters)
            {
                if(parameter.SyncObject==SyncModels.SyncObjects.Calendar)
                {
                    syncObjects.Add(new CalendarYClienstSyncObject("",0,1));
                }
                if(parameter.SyncObject == SyncModels.SyncObjects.Equipment)
                {
                    syncObjects.Add(new EquipmentYClienstSyncObject());
                }
            }
            return syncObjects;
        }
       
    }
}
