﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Communication.Service.Events
{
    public enum ErrorTypes
    {
        Receive,
        Send,
        SocketConnect,
        SocketAccept,
        ServerStart,
        ServerStop,
        Other,
    }
}