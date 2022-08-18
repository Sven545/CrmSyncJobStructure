using CRMSyncJobStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Services
{
    public class CalendarSyncService : ISyncService
    {
        public ISyncProvider Provider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CalendarSyncService(ISyncProvider provider)
        {
            Provider = provider;
        }

        public void SyncRoomAsync()
        {
            throw new NotImplementedException();
        }
    }
}
