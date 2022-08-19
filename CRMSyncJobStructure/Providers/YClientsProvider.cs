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
        

        /// <summary>
        /// Список объектов синхронизации формируем на уровне клиента
        /// </summary>
        public IEnumerable<ISyncObject> SyncObjects { get; set ; }

        /// <summary>
        /// Сервис авторизации
        /// </summary>
        public ISyncAuthService AuthService { get ; }

        /// <summary>
        /// Сервис авторизации выбираем ранее. Возможно на уровне сервиса, либо на уровне клиента с помощью абстрактной фабрики
        /// </summary>        
        public YClientsProvider(ISyncAuthService authService)
        {

            AuthService = authService;
            //авторизация. Скорее всего будет вынесена в отдельное API MB
           // AuthorizationYClientsService authService = new AuthorizationYClientsService("f3fyrwtb4npu9wrt53nx");
            //var authRes = authService.Authorize(userLogin: "", userPassword: "");
            //сохраняем для последующего использования partnerToken
        }
        /*
        public void AddSyncObject(ISyncObject syncObject)
        {
            //SyncObjects.Add(syncObject);
        }

        public void RemoveSyncObject(ISyncObject syncObject)
        {
           // SyncObjects.Remove(syncObject);
        }
        */
        public void DoSyncObjects()
        {
            foreach (var syncEntity in SyncObjects)
            {
                syncEntity.DoSynchronization();
            }
        }

        public void Authorize()
        {
            AuthService.Authorize();
        }
    }
}
