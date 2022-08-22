using System;
using CRMSyncJobStructure.Jobs;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.SyncServices;
using CRMSyncJobStructure.Providers;
using CRMSyncJobStructure.SyncObjects;
using CRMSyncJobStructure.YClientsApiServices;
using System.Linq;
using CRMSyncJobStructure.Factories.ServiceFactories;
using System.Collections.Generic;
using CRMSyncJobStructure.YClientsEntities.SimpleEntities;
using CRMSyncJobStructure.SyncModels.EntitiesRelations;
using CRMSyncJobStructure.SyncModels.SyncConfiguration;
using CRMSyncJobStructure.SyncModels;

namespace CRMSyncJobStructure
{
    public static class Program
    {
        private const string partnerToken = "f3fyrwtb4npu9wrt53nx";
        private static UserYClients user;
        static void Main(string[] args)
        {
            SyncConfig config = new SyncConfig()
            {
                Crm = CrmSystems.YClients,
                SyncStatus = true,
                SyncRule = SyncRules.AllIn,
                Calendars = new CommonSyncObjectConfiguration()
                {
                    SyncStatus = true,
                    ParentIdMusBooking="roomIdMb",
                    ParentIdCrm="staffIdYClients"
                },
                Rooms = new CommonSyncObjectConfiguration()
                {
                    SyncStatus = false,
                    ParentIdCrm = "testCompanyId",
                    
                }
                
                
            };
            var factory = SyncServiceFactory.GetSyncServiceFactory(config);
            var service = factory.GetSyncService();
            // service.Synchronize();
           

            /*
            var yClientsFactory = new SyncServiceYClientsFactory();
            var service = yClientsFactory.GetSyncService(new List<SyncModels.SyncObjects>());
            SyncJob job = new SyncJob(service);
            */
            // job.RunAsync();
            /*
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
            StaffYClientsServiceApi staffService = new StaffYClientsServiceApi(partnerToken, user.Token);
            StaffYClients staff = new StaffYClients()
            {
                CompanyId = 668467,
                Information = "test staff",
                Name = "Код сотрудник",
                Specialization = "Тестировщик"
            };
            
            var resStaff = staffService.AddStaff(staff);
            resStaff = staffService.GetOneStaff(staff.CompanyId, resStaff.Id);
            resStaff.Name = "Changed Name";
            var newResStaff = staffService.ChangeStaff(resStaff);
            staffService.RemoveStaff(staff.CompanyId, resStaff.Id);
            */
            /*
            
            
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
            */
        }
    }
    /// <summary>
    /// Пример работы с сервисами синхронизации из контроллера
    /// </summary>
    public class SyncController
    {
        public void Sync(object SyncSettingsFromClient)
        {
            //На основе параметров, по которым хотим синхронизироваться
            //полученных от клиента применяем тот или иной сервис синхронизации
            //так например можно передавать систему, с которой надо засинхрониться {"system":"yClients"}
            //На основе чего создаем конкретную фабрику
            //Здесь же мы должны распарсить настройки синхронизации и передать их в фабрику{"calendar":"true","room":"false" и т.д}

            //Где то здесь мы должны получить:
            // -параметры для авторизации конкретного пользователя
            // -список объектов, которые нужно синхронизировать(записываем в базу для робота и используем здесь)
            /*
            var yClientsFactory = new SyncServiceYClientsFactory();
            var service = yClientsFactory.GetSyncService(new List<SyncModels.SyncObjects>());
            service.Authorize();
            service.Synchronize();
            */
        }
        /// <summary>
        /// Метод отвечает за получение информации о структурах сущностей конуретного партнера 
        /// у MB и сторонней CRM
        /// </summary>
        /*
        public GroupsEntitiesRelation GetEntitiesStructure()
        {
            
            var yClientsFactory = new SyncServiceYClientsFactory();//если синхронизируем YClients, или любую другую фабрику для другой CRM
            var service = yClientsFactory.GetSyncService(new List<SyncModels.SyncObjects>());
            service.Authorize();
            var result = service.GetEntitiesRelations();
            return result;
            
        }*/
    }
}
