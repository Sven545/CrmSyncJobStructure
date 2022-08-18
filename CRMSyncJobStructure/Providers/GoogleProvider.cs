using CRMSyncJobStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Providers
{
    public class GoogleProvider : ISyncProvider
    {
        public IList<ISyncObject> SyncObjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddSyncObject(ISyncObject syncObject)
        {
            throw new NotImplementedException();
        }

        public void Authorize()
        {
            throw new NotImplementedException();
        }

        public void RemoveSyncObject(ISyncObject syncObject)
        {
            throw new NotImplementedException();
        }

        public void DoSyncObjects()
        {
            throw new NotImplementedException();
        }
    }
}
