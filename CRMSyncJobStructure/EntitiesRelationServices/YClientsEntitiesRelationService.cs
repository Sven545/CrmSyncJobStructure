using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.SyncModels.EntitiesRelations;
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
            RecordService = new RecordYClientsServiceApi("f3fyrwtb4npu9wrt53nx", "57961160e1cb93f3bb108bf5183b3ede");
            StaffService = new StaffYClientsServiceApi("f3fyrwtb4npu9wrt53nx", "57961160e1cb93f3bb108bf5183b3ede");
        }
        public GroupsEntitiesRelation GetGroupsEntitiesRelation()
        {

            var records = RecordService.GetRecords("668467");
            throw new NotImplementedException();
        }
    }
}
