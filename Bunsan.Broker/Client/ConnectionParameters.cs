﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunsan.Broker.Client
{
    [ProtoContract]
    class ConnectionParameters
    {
        [ProtoMember(1, IsRequired = false)]
        public string Identifier { get; set; }

        [ProtoMember(2, IsRequired = false)]
        public Connection Connection { get; set; }

        [ProtoMember(3, IsRequired = false)]
        public Credentials Credentials { get; set; }
    }
}