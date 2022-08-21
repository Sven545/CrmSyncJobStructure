using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.YClientsEntities.SimpleEntities;

namespace CRMSyncJobStructure.YClientsEntities.Responses
{
    public class StaffsResponse:BaseResponseYClients
    {
        public StaffYClients[] Data { get; set; }
    }
}
