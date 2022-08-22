using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSyncJobStructure.SyncModels.EntitiesRelations;

namespace CRMSyncJobStructure.Abstracts
{
    public interface IEntitiesRelationService
    {
        public GroupsEntitiesRelation GetGroupsEntitiesRelation();
    }
}
