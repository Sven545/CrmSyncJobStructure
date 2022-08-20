using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CRMSyncJobStructure.YClientsEntities.Responses;
using CRMSyncJobStructure.YClientsEntities.SimpleEntities;

namespace CRMSyncJobStructure.YClientsApiServices
{
    public class AuthorizationYClientsServiceApi
    {
        public string PartnerToken { get; set; } 
        public AuthorizationYClientsServiceApi(string partnerToken)
        {
            PartnerToken = partnerToken;
        }

        public UserYClients Authorize(string userLogin, string userPassword)
        {
            try
            {
                var url = "https://api.yclients.com/api/v1/auth";
                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {PartnerToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var args = new { login = userLogin, password = userPassword };
                string jsonString = JsonSerializer.Serialize(args);
                string result = client.UploadString(new Uri(url), jsonString);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                AuthResponseYClients response = JsonSerializer.Deserialize<AuthResponseYClients>(result, options);
                return response.Data;
            }
            catch(Exception)
            {
                throw new UnauthorizedAccessException("Ошибка авторизации");
            }
           
        }
    }
}
