using CRMSyncJobStructure.YClientsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsServices
{
    /// <summary>
    /// Общий сервис доступа к сущностям YClients
    /// </summary>
    public class CommonYClientsService
    {
        public UserYClients User { get; set; }

        public AuthorizationYClientsService AuthorizationService { get; set; }
        public RecordYClientsService Records { get; set; }
        public StaffYClientsService Staffs { get; set; }

        public CommonYClientsService(string userLogin, string userPassword, string partnerToken)
        {
            //partnetToken можно получать прямо здесь из конфига
            AuthorizationService.Authorize(userLogin, userPassword);

            Records = new RecordYClientsService(partnerToken, User.Token);
            Staffs = new StaffYClientsService(partnerToken, User.Token);
        }

    }
}
