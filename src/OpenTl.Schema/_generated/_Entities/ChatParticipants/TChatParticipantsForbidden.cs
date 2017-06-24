﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xfc900c2b)]
	public class TChatParticipantsForbidden : IChatParticipants
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       public int ChatId {get; set;}

       [SerializationOrder(2)]
       [CanSerialize("Flags", 0)]
       public IChatParticipant SelfParticipant {get; set;}

	}
}