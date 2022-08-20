using System;
using CRMSyncJobStructure.Jobs;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.SyncServices;
using CRMSyncJobStructure.Providers;
using CRMSyncJobStructure.SyncObjects;
using CRMSyncJobStructure.YClientsApiServices;
using System.Linq;
using CRMSyncJobStructure.ServiceFactories;
using CRMSyncJobStructure.SyncModels;
using System.Collections.Generic;
using CRMSyncJobStructure.YClientsEntities.SimpleEntities;

namespace CRMSyncJobStructure
{
    public static class Program
    {
        private const string partnerToken = "f3fyrwtb4npu9wrt53nx";
        private static UserYClients user;
        static void Main(string[] args)
        {

            ISyncServiceAbstractFactory yClientsFactory = new SyncServiceYClientsFactory();
            var service = yClientsFactory.GetSyncService(new List<SyncObjectsEnum>());
            SyncJob job = new SyncJob(service);

            job.RunAsync();

            AuthorizationYClientsServiceApi authService = new AuthorizationYClientsServiceApi(partnerToken);
            try
            {
                user = authService.Authorize("79671787704", "qwerty123");
                Console.WriteLine(user.Name + " " + user.Token);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);

            }
            RecordYClientsServiceApi recordsService = new RecordYClientsServiceApi(partnerToken, user.Token);
            //var records = recordsService.GetRecords(668467);
            //var firstRecord = recordsService.GetOneRecord(668467, (int)records.FirstOrDefault().Id);
            RecordYClients newRecord = new RecordYClients()
            {
                StaffId = 1909274,
                Services = new ServiceYClients[0],
                Client = new ClientYClients(),
                CompanyId = 668467,
                DateTime = DateTime.Now,
                Length = 3600
            };
            try
            {
                var resRecord = recordsService.AddRecord(newRecord);
                var resRecord1 = resRecord;
                var datetime = resRecord.DateTime.AddHours(1);
                resRecord1.DateTime = datetime;
                var resRecord2 = recordsService.ChangeRecord(resRecord1);
                recordsService.RemoveRecord(resRecord.CompanyId, (int)resRecord.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    /// <summary>
    /// Пример работы с сервисами синхронизации из контроллера
    /// </summary>
    public class SyncController
    {
        public void Sync(object someSyncParameters)
        {
            //На основе параметров, по которым хотим синхронизироваться
            //полученных от клиента применяем тот или иной сервис синхронизации
            //так например можно передавать систему, с которой надо засинхрониться {"system":"yClients"}
            //На основе чего создаем конкретную фабрику
            //Здесь же мы должны распарсить настройки синхронизации и передать их в фабрику{"calendar":"true","room":"false" и т.д}

            //Где то здесь мы должны получить:
            // -параметры для авторизации конкретного пользователя
            // -список объектов, которые нужно синхронизировать(записываем в базу для робота и используем здесь)
            var yClientsFactory = new SyncServiceYClientsFactory();
            var service = yClientsFactory.GetSyncService(new List<SyncObjectsEnum>());
            service.Authorize();
            service.Synchronize();
        }
        /// <summary>
        /// Метод отвечает за получение информации о структурах сущностей конуретного партнера 
        /// у MB и сторонней CRM
        /// </summary>
        public GroupsEntitiesRelation GetEntitiesStructure()
        {
            var yClientsFactory = new SyncServiceYClientsFactory();//если синхронизируем YClients, или любую другую фабрику для другой CRM
            var service = yClientsFactory.GetSyncService(new List<SyncObjectsEnum>());
            service.Authorize();
            var result = service.GetEntitiesRelations();
            return result;
        }
    }
}
