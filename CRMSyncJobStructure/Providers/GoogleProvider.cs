using CRMSyncJobStructure.Abstracts;
using CRMSyncJobStructure.SyncModels.EntitiesRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Providers
{
    public class GoogleProvider : ISyncProvider
    {
        public ISyncAuthService AuthService => throw new NotImplementedException();

        public IEnumerable<ISyncObject> SyncObjects { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEntitiesRelationService EntitiesRelationService { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Authorize()
        {
            throw new NotImplementedException();
        }

        public void DoSyncObjects()
        {
            throw new NotImplementedException();
        }

        public GroupsEntitiesRelation GetEntitiesRelations()
        {
            throw new NotImplementedException();
        }
    }
}
