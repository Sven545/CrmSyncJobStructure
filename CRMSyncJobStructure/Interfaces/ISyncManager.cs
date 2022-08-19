using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.SyncModels;

namespace CRMSyncJobStructure.Interfaces
{
    /// <summary>
    /// Отвечает за формирование объектов синхронизации
    /// </summary>
    public interface ISyncManager
    {
        /// <summary>
        /// Возвращает объекты синхронизации на основании каких то входных данных
        /// </summary>   
        public IEnumerable<ISyncObject> GetSyncObjects();
    }
}
