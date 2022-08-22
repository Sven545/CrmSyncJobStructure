using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Factories.ServiceFactories;
using CRMSyncJobStructure.SyncModels;
using CRMSyncJobStructure.SyncModels.SyncConfiguration;

namespace CRMSyncJobStructure.Abstracts
{

    public abstract class SyncServiceFactory
    {
        public abstract ISyncService GetSyncService(/*IEnumerable<SyncModels.SyncObjects> objectsForSync*/);
        /// <summary>
        /// Фабричный метод для получения нужного настроенного экземпляра фабрики
        /// </summary>
        public static SyncServiceFactory GetSyncServiceFactory(SyncConfig config)
        {
            if (config.SyncStatus == false)//нужно вынести выше, так как принятие решения о синхронизации делается раньше
            {

            }
            if (config.Crm == CrmSystems.YClients)
            {

            }
            return new SyncServiceYClientsFactory(GetManagerParameters(config));
        }

        /// <summary>
        /// Получаем параметры для менеджера, на основании которых будет сформирован список объектов синхронизации
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        private static IEnumerable<ISyncManagerParameters> GetManagerParameters(SyncConfig config)
        {
            List<ISyncManagerParameters> parameters = new List<ISyncManagerParameters>();
            /*
            if (config.Domains.SyncStatus)
            {
                var syncRule = config.SyncRule ?? config.Domains.CommonSyncRule;
                parameters.Add(new ManagerParameters() { SyncObject = SyncModels.SyncObjects.Domain, SyncRule = syncRule });

            }
            if (config.Bases.SyncStatus)
            {
                var syncRule = config.SyncRule ?? config.Bases.CommonSyncRule;
                parameters.Add(new ManagerParameters() { SyncObject = SyncModels.SyncObjects.Base, SyncRule = syncRule });
            }

            if (config.Rooms.SyncStatus)
            {
                var syncRule = config.SyncRule ?? config.Rooms.CommonSyncRule;
                parameters.Add(new ManagerParameters() { SyncObject = SyncModels.SyncObjects.Room, SyncRule = syncRule });
            }
            */
            if (config.Calendars.SyncStatus)
            {
                var syncRule = config.SyncRule ?? config.Calendars.CommonSyncRule;
                parameters.Add(new ManagerYClientsParameters()
                {
                    CompanyId = config.Rooms.ParentIdCrm,
                    SyncObjectType = SyncModels.SyncObjects.Calendar,
                    SyncObjectCongiguration = config.Calendars
                });
            }
            return parameters;
        }
    }
}
