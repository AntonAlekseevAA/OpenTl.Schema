﻿namespace OpenTl.Schema.Messages
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x78337739)]
    public class RequestReorderStickerSets : IRequest<bool>
    {
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Masks {get; set;}

       [SerializationOrder(2)]
       public TVector<long> Order {get; set;}

    }
}