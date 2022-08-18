using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.YClientsServices;

namespace CRMSyncJobStructure.Providers
{
    public class YClientsProvider : ISyncProvider
    {
        public string PartnerToken { get; set; }
        public string UserToken { get; set; }

        public IList<ISyncObject> SyncObjects { get; set ; }
        public YClientsProvider(IList<ISyncObject> syncEntitties = null)
        {
            if (syncEntitties == null)
            {
                SyncObjects = new List<ISyncObject>();
            }
            else
            {
                SyncObjects = syncEntitties;
            }

            //авторизация. Скорее всего будет вынесена в отдельное API MB
            AuthorizationYClientsService authService = new AuthorizationYClientsService("f3fyrwtb4npu9wrt53nx");
            var authRes = authService.Authorize(userLogin: "", userPassword: "");
            //сохраняем для последующего использования partnerToken
        }

        public void AddSyncObject(ISyncObject syncObject)
        {
            SyncObjects.Add(syncObject);
        }

        public void RemoveSyncObject(ISyncObject syncObject)
        {
            SyncObjects.Remove(syncObject);
        }

        public void DoSyncObjects()
        {
            foreach (var syncEntity in SyncObjects)
            {
                syncEntity.DoSynchronization();
            }
        }


    }
}
