﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Communication.Service.DataPackets
{
    public class GetReportIntervalPacket : OperPacketBase
    {
        public GetReportIntervalPacket() : base(PacketTypeEnum.GetReportInterval)
        {
            BodyLen = OperPacketBodyLen;
        }
    }
}
