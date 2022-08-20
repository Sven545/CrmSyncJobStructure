using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsEntities.SimpleEntities
{
    public class ServiceYClients
    {
        public int Category_id { get; set; }
        public string Title { get; set; }
        public int Price_min { get; set; }
        public int Price_max { get; set; }
        public int Duration { get; set; }
        public int Active { get; set; }
        public string Comment { get; set; }
        public string Api_id { get; set; }
        public int Weight { get; set; }
        public StaffYClients[] Staff { get; set; }
    }
}
