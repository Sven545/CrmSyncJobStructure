using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.YClientsApiServices;

namespace CRMSyncJobStructure.SyncObjects
{
    /// <summary>
    /// Объект синхронизации "Календарь", которые знает конкретный способ синхронизации. AllIn
    /// </summary>
    public class CalendarYClienstSyncObject : ISyncObject
    {
        private int _yClientsStaffId;
        private int _yClientsCompanyId;
        private string _musBookingRoomId;
        public RecordYClientsServiceApi RecordService { get; set; }
        public StaffYClientsServiceApi StaffService { get; set; }
        public object DataBase { get; set; }
        //На этапе привязки сохраняем в БД в таблицу партнерских зон параметры,
        //по которым будет связь с внешними CRM

        /// <summary>
        /// Должны знать id комнаты у нас, в которую копируем записи YClients, а так же id компании и сотрудника YClients, от которого происходит копирование
        /// </summary>    
        public CalendarYClienstSyncObject(string musBookingRoomId,int yClientsCompanyId,int yClientsStaffId)
        {
            _musBookingRoomId = musBookingRoomId;
            _yClientsStaffId = yClientsStaffId;
            _yClientsCompanyId=yClientsCompanyId;

            RecordService = new RecordYClientsServiceApi("f3fyrwtb4npu9wrt53nx", "57961160e1cb93f3bb108bf5183b3ede");
            StaffService = new StaffYClientsServiceApi("f3fyrwtb4npu9wrt53nx", "57961160e1cb93f3bb108bf5183b3ede");
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
            //Должны знать:
            //-companyId
            //-staffId
           
            var res = RecordService.GetRecords(companyId: _yClientsCompanyId,staffId: _yClientsStaffId);


            //логика синхронизации: сохраняем эти заказы у нас и
            //возможно загружаем наши заказы на YClients на пустые места
            //с учетом условия выбранных параметров синхронизации. Если место занято-игнор

            //Тип синхронизации можно будет динамически передавать в параметрах метода. Например:
            //- полная передача от них к нам (копия их записей у нас, лишние записи удаляются)
            //- полная передача от нас к ним (копия наших записей у них, лишние записи удаляются)
            //- частичная синхронизация (когда мы получаем недостающие записи от них, они получают недостающие записи от нас)

            //Либо сам этот класс будет динамически выбираться на этапе формирования списка ISyncObjects
            //в зависимости от выбранного способа синхронизации (CalendarYClienstSyncObjectAllIn,CalendarYClienstSyncObjectAllOut,CalendarYClienstSyncObjectDouble)


           
        }


    }
}
