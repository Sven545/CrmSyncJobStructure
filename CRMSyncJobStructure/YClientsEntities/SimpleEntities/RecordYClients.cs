using CRMSyncJobStructure.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsEntities.SimpleEntities
{
    public class RecordYClients : ICrmEntity
    {
        public int Id { get; set; }

        [JsonPropertyName("company_id")]
        public int CompanyId { get; set; }

        [JsonPropertyName("staff_id")]
        public int StaffId { get; set; }
        public ServiceYClients[] Services { get; set; }
        public StaffYClients Staff { get; set; }
        public ClientYClients Client { get; set; }
        public DateTime DateTime { get; set; }

        [JsonPropertyName("create_date")]
        public string CreateDate { get; set; }//string вместо DateTime так как от YC приходит в формате
                                              //2022-08-12T18:57:44+0300 вместо 2022-08-12T18:57:44+03:00
        public int Length { get; set; }


        public string EntityId
        {
            get { return Id.ToString(); }
        }

        public string EntityParentId
        {
            get
            {
                return StaffId.ToString();
            }
        }

        public string EntityName
        {
            get { return "Запись от YClients"; }
        }
    }
}
