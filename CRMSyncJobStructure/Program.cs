using System;
using CRMSyncJobStructure.Jobs;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.Services;
using CRMSyncJobStructure.Providers;
using CRMSyncJobStructure.SyncObjects;
using CRMSyncJobStructure.YClientsServices;
using CRMSyncJobStructure.YClientsEntities;
using System.Linq;
using CRMSyncJobStructure.ServiceFactories;

namespace CRMSyncJobStructure
{
    public static class Program
    {
        private const string partnerToken = "f3fyrwtb4npu9wrt53nx";
        private static UserYClients user;
        static void Main(string[] args)
        {

            ISyncServiceAbstractFactory yClientsFactory = new ServiceYClientsFactory();
            var service = yClientsFactory.GetSyncService();
            SyncJob job=new SyncJob(service);

            AuthorizationYClientsService authService = new AuthorizationYClientsService(partnerToken);
            try
            {
                user = authService.Authorize("79671787704", "qwerty123");
                Console.WriteLine(user.Name + " " + user.Token);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);

            }
            RecordYClientsService recordsService = new RecordYClientsService(partnerToken, user.Token);
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
}
