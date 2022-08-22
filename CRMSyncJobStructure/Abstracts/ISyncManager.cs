using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.SyncModels;

namespace CRMSyncJobStructure.Abstracts
{
    /// <summary>
    /// Отвечает за формирование объектов синхронизации
    /// </summary>
    public interface ISyncManager
    {
        public IEnumerable<ISyncManagerParameters> SyncParameters { get; }
        /// <summary>
        /// На уровне сервиса формируем список объектов для синхронизации(комната, календарь, оборудование)
        /// </summary>   
        public IEnumerable<ISyncObject> GetSyncObjects();

    }
}
