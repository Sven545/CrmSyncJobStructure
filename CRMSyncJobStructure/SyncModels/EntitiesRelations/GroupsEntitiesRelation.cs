using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels.EntitiesRelations
{
    public class GroupsEntitiesRelation
    {
        public CrmSystems Crm { get; set; }
        public EntitiesRelation Domains { get; set; }
        public EntitiesRelation Bases { get; set; }
        public EntitiesRelation Rooms { get; set; }
        public EntitiesRelation Records { get; set; }
        public EntitiesRelation Equipments { get; set; }
    }
}
