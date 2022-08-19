using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Interfaces
{
    /// <summary>
    /// Абстрактный провайдер, в который можно динамически добавлять сущности синхронизации
    /// </summary>
    public interface ISyncProvider
    {
        public ISyncAuthService AuthService { get;  }
        public IEnumerable<ISyncObject> SyncObjects { get; set; }

       // public void AddSyncObject(ISyncObject syncObject);
       // public void RemoveSyncObject(ISyncObject syncObject);

        public void DoSyncObjects();
        public void Authorize();
    }
}
