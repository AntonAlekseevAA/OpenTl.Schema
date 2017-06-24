﻿namespace OpenTl.Schema
{
	using System;
	using System.Collections;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x3417d728)]
	public class TInputPaymentCredentials : IInputPaymentCredentials
	{
       [SerializationOrder(0)]
       public BitArray Flags {get; set;}

       [SerializationOrder(1)]
       [FromFlag("Flags", 0)]
       public bool Save {get; set;}

       [SerializationOrder(2)]
       public IDataJSON Data {get; set;}

	}
}