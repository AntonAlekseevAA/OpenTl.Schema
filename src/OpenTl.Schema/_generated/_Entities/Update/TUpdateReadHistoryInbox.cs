﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x9961fd5c)]
	public class TUpdateReadHistoryInbox : IUpdate
	{
       [SerializationOrder(0)]
       public IPeer Peer {get; set;}

       [SerializationOrder(1)]
       public int MaxId {get; set;}

       [SerializationOrder(2)]
       public int Pts {get; set;}

       [SerializationOrder(3)]
       public int PtsCount {get; set;}

	}
}