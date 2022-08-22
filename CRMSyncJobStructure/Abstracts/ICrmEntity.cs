using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Abstracts
{
    public interface ICrmEntity
    {
        public string EntityId { get; }
        public string EntityParentId { get; }
        public string EntityName { get; }
    }
}
