using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CRMSyncJobStructure.YClientsEntities;

namespace CRMSyncJobStructure.YClientsServices
{
    /// <summary>
    /// Сервис для работы с сущностью "Запись" YClients API
    /// </summary>
    public class RecordYClientsServiceApi
    {
        private readonly string _partnerToken;
        private readonly string _userToken;
        public RecordYClientsServiceApi(string partnerToken, string userToken)
        {
            _partnerToken = partnerToken;
            _userToken = userToken;
        }

        public RecordYClients AddRecord(RecordYClients record)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/records/{record.CompanyId}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var args = new
                {
                    staff_id = record.StaffId,
                    services = record.Services,
                    client = record.Client,
                    datetime = record.DateTime,
                    seance_length = record.Length,
                    comment = "testC Comment",
                };
                string jsonString = JsonSerializer.Serialize(args);
                string result = client.UploadString(new Uri(url), jsonString);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                RecordResponseYClients response = JsonSerializer.Deserialize<RecordResponseYClients>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }

        }

        public RecordYClients ChangeRecord(RecordYClients record)
        {


            try
            {
                var url = $"https://api.yclients.com/api/v1/record/{record.CompanyId}/{record.Id}";

                using WebClient client = new WebClient();
                client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
                client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var args = new
                {
                    staff_id = record.StaffId,
                    services = record.Services,
                    client = record.Client,
                    datetime = record.DateTime,
                    seance_length = record.Length,
                    comment = "testC Comment",
                };
                string jsonString = JsonSerializer.Serialize(args);
                string result = client.UploadString(new Uri(url), WebRequestMethods.Http.Put, jsonString);

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };
                RecordResponseYClients response = JsonSerializer.Deserialize<RecordResponseYClients>(result, options);
                return response.Data;
            }
            catch (WebException ex)
            {
                var bodyAsTextTask = new System.IO.StreamReader(ex.Response.GetResponseStream()).ReadToEndAsync();
                throw new Exception(bodyAsTextTask.Result);

            }
        }

        public RecordYClients GetOneRecord(int companyId, int recordId)
        {

            var url = $"https://api.yclients.com/api/v1/record/{companyId}/{recordId}";
            using WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
            client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            string result = client.DownloadString(url);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            RecordResponseYClients response = JsonSerializer.Deserialize<RecordResponseYClients>(result, options);
            return response.Data;
        }

        public IEnumerable<RecordYClients> GetRecords(int companyId)
        {
            var url = $"https://api.yclients.com/api/v1/records/{companyId}";

            using WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.Authorization] = $"Bearer {_partnerToken}, User {_userToken}";
            client.Headers[HttpRequestHeader.Accept] = "application/vnd.yclients.v2+json";
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            string result = client.DownloadString(url);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
            RecordsResponseYClients response = JsonSerializer.Deserialize<RecordsResponseYClients>(result, options);
            return response.Data;
        }

        public void RemoveRecord(int companyId, int recordId)
        {
            try
            {
                var url = $"https://api.yclients.com/api/v1/record/{companyId}/{recordId}";

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
