using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.Interfaces;

namespace CRMSyncJobStructure.Providers
{
    public class OtherProvider : ISyncProvider
    {
        public IEnumerable<ISyncObject> SyncEntitties { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IList<ISyncObject> ISyncProvider.SyncObjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
