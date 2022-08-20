using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.SyncModels;
using CRMSyncJobStructure.YClientsApiServices;

namespace CRMSyncJobStructure.EntitiesRelationServices
{
    /// <summary>
    /// Отвечает за формирование соответствия между группами сущностей MB и YClients
    /// </summary>
    public class YClientsEntitiesRelationService : IEntitiesRelationService
    {
        private RecordYClientsServiceApi RecordService { get; }
        private StaffYClientsServiceApi StaffService { get; }
        private object DataBase { get; }
        public YClientsEntitiesRelationService()
        {
            //userToken и partnerToken получаем из БД(записали на этапе авторизации) и из конфига
            //либо можно получать на этапе формирования YClientsSyncService в фабрике
            RecordService = new RecordYClientsServiceApi("", "");
            StaffService = new StaffYClientsServiceApi("", "");
        }
        public GroupsEntitiesRelation GetGroupsEntitiesRelation()
        {

            var records = RecordService.GetRecords(123);
            throw new NotImplementedException();
        }
    }
}
