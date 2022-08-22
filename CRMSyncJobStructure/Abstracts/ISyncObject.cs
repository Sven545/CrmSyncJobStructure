using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Abstracts
{
    /// <summary>
    /// Абстрактная сущность у нас, которая знает как себя синхронизировать
    /// </summary>
    public interface ISyncObject
    {
        public void DoSynchronization();
    }
}
