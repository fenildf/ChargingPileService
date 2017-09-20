﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChargingPileService.Models
{
    [Serializable]
    public class MulResult<T> : ResultBase
    {
        public MulResult() : base()
        {
            this.OperateResult = new List<T>();
        }

        public List<T> OperateResult { get; set; }
    }
}
