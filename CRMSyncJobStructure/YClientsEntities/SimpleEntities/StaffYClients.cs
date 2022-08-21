using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CRMSyncJobStructure.YClientsEntities.SimpleEntities
{
    public class StaffYClients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        [JsonPropertyName("company_id")]
        public int CompanyId { get; set; }
        public string  Information { get; set; }
    }
}
