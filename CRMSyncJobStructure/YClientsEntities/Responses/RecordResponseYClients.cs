﻿using CRMSyncJobStructure.YClientsEntities.SimpleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.YClientsEntities.Responses
{
    public class RecordResponseYClients : BaseResponseYClients
    {
        public RecordYClients Data { get; set; }

    }
}
