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
       

       // IEnumerable<ISyncManagerParameters> SyncParameters { get; }

       public IEnumerable<ISyncManagerParameters> SyncParameters { get; }

        /// <summary>
        /// В конструкторе передаем объект, на основании которого будет сформирован список объектов синхронизации
        /// Возможно при болле глубокой логике синхронизации заменим на отдельный класс с параметрами
        /// </summary>       
        public YClientsSyncManager(IEnumerable<ISyncManagerParameters> parameters)
        {
            SyncParameters = parameters ;
        }
        /// <summary>
        /// Логика выбора объектов синхронизации
        /// Пока игнорируем правила SyncRules
        /// </summary>        
        public IEnumerable<ISyncObject> GetSyncObjects()
        {

            List<ISyncObject> syncObjects = new List<ISyncObject>();
          
            foreach (var parameter in SyncParameters)
            {
               var newParameter = parameter as ManagerYClientsParameters;
                if(newParameter.SyncObjectType==SyncModels.SyncObjects.Calendar)
                {
                    syncObjects.Add(new CalendarYClienstSyncObject(
                        newParameter.SyncObjectCongiguration.ParentIdMusBooking,
                        newParameter.CompanyId,
                        newParameter.SyncObjectCongiguration.ParentIdCrm));
                }
                if(newParameter.SyncObjectType == SyncModels.SyncObjects.Equipment)
                {
                    syncObjects.Add(new EquipmentYClienstSyncObject());
                }
            }
            return syncObjects;
        }
       
    }
}
