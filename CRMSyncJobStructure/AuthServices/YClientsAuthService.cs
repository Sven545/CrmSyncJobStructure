using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.YClientsApiServices;

namespace CRMSyncJobStructure.AuthServices
{
    /// <summary>
    /// Конкретный сервис авторизации знает процедуру авторизации. Может работать и с БД для получения токенов
    /// и с API YClients
    /// </summary>
    public class YClientsAuthService : ISyncAuthService
    {
        private readonly string _userLogin;
        private readonly string _userPassword;
        private AuthorizationYClientsServiceApi _authApiYClientsService;
        private object dataBase;
        public YClientsAuthService(string partnerToken, string userLogin, string password)
        {
            _authApiYClientsService = new AuthorizationYClientsServiceApi(partnerToken);
            _userLogin = userLogin;
            _userPassword = password;
        }
        public void Authorize()
        {
            //Пробуем получить из БД userToken
            //если нет, пробуем авторизоваться с логином и паролем
            var authResult = _authApiYClientsService.Authorize(_userLogin, _userPassword);
            //Если все ок-сохраняем userToken в БД
           
        }
    }
}
