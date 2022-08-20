using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsApiServices
{
    public class CompanyYClientsServiceApi
    {
        private readonly string _partnerToken;
        private readonly string _userToken;
        public CompanyYClientsServiceApi(string partnerToken, string userToken)
        {
            _partnerToken = partnerToken;
            _userToken = userToken;
        }
        
    }
}
