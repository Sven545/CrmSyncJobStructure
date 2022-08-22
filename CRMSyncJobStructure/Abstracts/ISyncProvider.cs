using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.EntitiesRelationServices;
using CRMSyncJobStructure.SyncModels.EntitiesRelations;

namespace CRMSyncJobStructure.Abstracts
{
    /// <summary>
    /// Абстрактный провайдер, в который можно динамически добавлять сущности синхронизации
    /// </summary>
    public interface ISyncProvider
    {
        public ISyncAuthService AuthService { get;  }
        public IEnumerable<ISyncObject> SyncObjects { get; set; }
        public IEntitiesRelationService EntitiesRelationService { get; set; }


        public GroupsEntitiesRelation GetEntitiesRelations();
        public void DoSyncObjects();
        public void Authorize();
    }
}
