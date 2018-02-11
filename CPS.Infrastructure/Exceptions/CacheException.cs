﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Infrastructure.Exceptions
{
    public class CacheException : Exception
    {
        public CacheException()
        {
        }

        public CacheException(string message) : base(message)
        {
        }

        public CacheException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CacheException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
