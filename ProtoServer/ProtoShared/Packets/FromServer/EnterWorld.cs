﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using UnityEngine;
using ProtoShared.Data;

namespace ProtoShared.Packets.FromServer
{
    public class EnterWorld : ProtoShared.Packets.BaseMessage
    {
        public static Int16 ID;
        [ProtoMember(2)]
        public Player Player;


        public EnterWorld() : base(ID) { }
    }
}