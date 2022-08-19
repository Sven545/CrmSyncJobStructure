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
using CRMSyncJobStructure.Services;

namespace CRMSyncJobStructure.ServiceFactories
{
    public class ServiceYClientsFactory : ISyncServiceAbstractFactory
    {
        public ISyncService GetSyncService()
        {
            var authService = new YClientsAuthService();
            var provider = new YClientsProvider(authService);
            var manager = new YClientsSyncManager(new List<SyncObjectsEnum>());
            var service = new CrmSyncService(provider, manager);
            return service;
        }
    }
}
