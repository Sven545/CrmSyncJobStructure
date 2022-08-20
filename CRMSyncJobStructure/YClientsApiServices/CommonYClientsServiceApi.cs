using CRMSyncJobStructure.YClientsEntities.SimpleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsApiServices
{
    /// <summary>
    /// Общий сервис доступа к сущностям YClients
    /// </summary>
    public class CommonYClientsServiceApi
    {
        public UserYClients User { get; set; }

        public AuthorizationYClientsServiceApi AuthorizationService { get; set; }
        public RecordYClientsServiceApi Records { get; set; }
        public StaffYClientsServiceApi Staffs { get; set; }

        public CommonYClientsServiceApi(string userLogin, string userPassword, string partnerToken)
        {
            //partnetToken можно получать прямо здесь из конфига
            AuthorizationService.Authorize(userLogin, userPassword);

            Records = new RecordYClientsServiceApi(partnerToken, User.Token);
            Staffs = new StaffYClientsServiceApi(partnerToken, User.Token);
        }

    }
}
