using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Interfaces
{
    public interface ICalendar : ISyncObject
    {
        public void AddRecord();
        public void RemoveRecord();
        public void ChangeRecord();
        public void GetOneRecord();
        public void GetRecords();
    }
}
