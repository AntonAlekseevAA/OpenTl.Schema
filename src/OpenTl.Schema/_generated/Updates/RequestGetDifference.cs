﻿namespace OpenTl.Schema.Updates
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x25939651)]
    public class RequestGetDifference : IRequest<Updates.IDifference>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int Pts {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public int PtsTotalLimit {get; set;}

       [SerializationOrder(3)]
       public int Date {get; set;}

       [SerializationOrder(4)]
       public int Qts {get; set;}

    }
}