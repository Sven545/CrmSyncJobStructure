using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;
using CRMSyncJobStructure.YClientsServices;

namespace CRMSyncJobStructure.SyncObjects
{
    /// <summary>
    /// Объект синхронизации "Календарь"
    /// </summary>
    public class CalendarYClienstSyncObject : ISyncObject
    {
       // public CommonYClientsService YClientsService { get; set; }
        public RecordYClientsService RecordService { get; set; }
        public object DataBase { get; set; }
        //На этапе привязки сохраняем в БД в таблицу партнерских зон параметры,
        //по которым будет связь с внешними CRM
        public CalendarYClienstSyncObject()
        {
            // YClientsService = new CommonYClientsService(userLogin, userPassword, partnerToken);
            //userToken и partnerToken получаем из БД(записали на эиапе авторизации) и из конфига
            RecordService = new RecordYClientsService("","");
        }
        /// <summary>
        /// В параметры данного метода возможно передавать параметры синхронизации, 
        /// т.е сущности, по которым синхронизируем
        /// </summary>
        public void DoSynchronization()
        {
            //логика синхронизации календарей
            //получаем с БД календари по type=yClients 
            //фильтруем по архивации, блокировке партнера и тд
            //получаем orders по roomId в календаре?? т.е все заказы для данной комныты, привязанной к данному
            //календарю

            //Имеем все заказы для данной комнаты

            //Получаем все заказы с календаря для сотрудника(комната по нашему) YClients

            //логика синхронизации: сохраняем эти заказы у нас и
            //возможно загружаем наши заказы на YClients на пустые места
            //с учетом условия выбранных параметров синхронизации. Если место занято-игнор


            throw new NotImplementedException();
        }


    }
}
