using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsEntities.SimpleEntities
{
    public class UserYClients
    {
        public int Id { get; set; }

        [JsonPropertyName("user_token")]
        public string Token { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
