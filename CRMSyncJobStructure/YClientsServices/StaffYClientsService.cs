using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsServices
{
    public class StaffYClientsService
    {
        public string PartnerToken { get; set; }
        public string UserToken { get; set; }
        public StaffYClientsService(string partnerToken, string userToken)
        {
            PartnerToken = partnerToken;
            UserToken = userToken;
        }
    }
}
