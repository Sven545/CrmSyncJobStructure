using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.AuthServices;
using CRMSyncJobStructure.Providers;
using CRMSyncJobStructure.SyncManagers;
using CRMSyncJobStructure.SyncModels;
using CRMSyncJobStructure.SyncServices;
using CRMSyncJobStructure.EntitiesRelationServices;

namespace CRMSyncJobStructure.ServiceFactories
{
    public class SyncServiceYClientsFactory : ISyncServiceAbstractFactory
    {
        //private IEnumerable<SyncObjectsEnum> SyncObjects { get; }
        public SyncServiceYClientsFactory()
        {
            //SyncObjects = syncObjects;
        }
        public ISyncService GetSyncService(IEnumerable<SyncObjectsEnum> objectsForSync)
        {
            var authService = new YClientsAuthService("", "", "");//данные для авторизации
            var entitiesRelationService = new YClientsEntitiesRelationService();
            var provider = new YClientsProvider(authService,entitiesRelationService);
            var manager = new YClientsSyncManager();
            var service = new CrmSyncService(provider, manager, objectsForSync);
            return service;
        }
    }
}
