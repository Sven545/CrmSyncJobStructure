using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSyncJobStructure.SyncModels
{
    /// <summary>
    /// Варианты синхронизации конкретного объекта
    /// </summary>
    public enum SyncRules
    {
        AllIn,//Полное копирование от нас к ним
        AllOut,//Полное копирование от них к нам
        Double//Обоюдное копирование(если будет необходимость)
    }
}
