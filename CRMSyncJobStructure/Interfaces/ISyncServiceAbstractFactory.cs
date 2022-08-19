using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Interfaces
{
    public interface ISyncServiceAbstractFactory
    {
        public ISyncService GetSyncService();
    }
}
