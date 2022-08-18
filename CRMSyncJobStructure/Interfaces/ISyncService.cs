﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.Interfaces
{
    /// <summary>
    /// Абстрактный сервис синхронизации, который может работать с любым провайдером
    /// </summary>
    public interface ISyncService
    {
        public ISyncProvider Provider { get; set; }
        public void SyncRoomAsync();
    }
}