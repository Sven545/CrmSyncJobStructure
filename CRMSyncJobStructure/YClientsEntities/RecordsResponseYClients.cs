﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsEntities
{
    public class RecordsResponseYClients:BaseResponseYClients
    {
        public RecordYClients[] Data { get; set; }
    }
}