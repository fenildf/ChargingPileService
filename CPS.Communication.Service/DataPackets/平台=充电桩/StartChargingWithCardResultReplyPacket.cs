﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Communication.Service.DataPackets
{
    public class StartChargingWithCardResultReplyPacket : StartChargingWithCardPacket
    {
        public StartChargingWithCardResultReplyPacket() : base(PacketTypeEnum.StartChargingWithCardResultReply)
        {
            BodyLen = 1 + CardNoLen + 8;
        }
    }
}
