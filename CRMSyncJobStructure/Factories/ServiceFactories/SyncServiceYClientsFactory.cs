using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.AuthServices;
using CRMSyncJobStructure.Providers;
using CRMSyncJobStructure.SyncManagers;
using CRMSyncJobStructure.SyncModels;
using CRMSyncJobStructure.SyncServices;
using CRMSyncJobStructure.EntitiesRelationServices;

namespace CRMSyncJobStructure.Factories.ServiceFactories
{
    public class SyncServiceYClientsFactory : SyncServiceFactory
    {
        private IEnumerable<ManagerParameters> _managerParameters;
        public SyncServiceYClientsFactory(IEnumerable<ManagerParameters> managerParameters)
        {
            _managerParameters = managerParameters;
            //SyncObjects = syncObjects;
        }
        public override ISyncService GetSyncService(/*IEnumerable<SyncModels.SyncObjects> objectsForSync*/)
        {
            var authService = new YClientsAuthService("", "", "");//данные для авторизации(изменить)
            var entitiesRelationService = new YClientsEntitiesRelationService();
            var provider = new YClientsProvider(authService,entitiesRelationService);
            var manager = new YClientsSyncManager(_managerParameters);//Нужно будет передать список объектов синхронизации и настройки для них
            var service = new CrmSyncService(provider, manager);
            return service;
        }
    }
}
