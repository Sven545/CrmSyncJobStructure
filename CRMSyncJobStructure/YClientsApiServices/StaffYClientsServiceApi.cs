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
    public class StaffYClientsServiceApi
    {
        private readonly string _partnerToken;
        private readonly string _userToken;
        public StaffYClientsServiceApi(string partnerToken, string userToken)
        {
            _partnerToken = partnerToken;
            _userToken = userToken;
        }
        public StaffYClients AddStaff(StaffYClients staff)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/staff/{staff.CompanyId}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var args = new
                {
                    name = staff.Name,
                    specialization = staff.Specialization,
                    weight = 10,
                    information = staff.Information,
                    api_id = 0,
                    hidden = 0,
                    fired = 0,
                    user_id = 0
                };
                string jsonString = JsonSerializer.Serialize(args);
                string result = client.UploadString(new Uri(url), jsonString);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                StaffResponseYClients response = JsonSerializer.Deserialize<StaffResponseYClients>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }
        public StaffYClients ChangeStaff(StaffYClients staff)
        {


            try
            {
                var url = $"https://api.yclients.com/api/v1/staff/{staff.CompanyId}/{staff.Id}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var args = new
                {
                    name = staff.Name,
                    specialization = staff.Specialization,
                    weight = 10,
                    information = staff.Information,
                    api_id = 1,
                    hidden = 0,
                    fired = 0,
                    user_id = 0
                };
                string jsonString = JsonSerializer.Serialize(args);
                string result = client.UploadString(new Uri(url), WebRequestMethods.Http.Put, jsonString);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                StaffResponseYClients response = JsonSerializer.Deserialize<StaffResponseYClients>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }
        public IEnumerable<StaffYClients> GetStaffs(int companyId)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/company/{companyId}/staff/";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";


                string result = client.DownloadString(url);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                StaffsResponse response = JsonSerializer.Deserialize<StaffsResponse>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }
        public StaffYClients GetOneStaff(int companyId, int staffId)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/company/{companyId}/staff/{staffId}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";


                string result = client.DownloadString(url);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                StaffResponseYClients response = JsonSerializer.Deserialize<StaffResponseYClients>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }
        public void RemoveStaff(int companyId, int staffId)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/staff/{companyId}/{staffId}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";


                string result = client.UploadString(new Uri(url), "DELETE", "");



            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }
    }
}
