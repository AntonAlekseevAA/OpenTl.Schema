﻿// ReSharper disable All

namespace OpenTl.Schema
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0x5eaa7809)]
	public class TInputSingleMedia : IInputSingleMedia
	{
       [SerializationOrder(0)]
       public OpenTl.Schema.IInputMedia Media {get; set;}

       [SerializationOrder(1)]
       public long RandomId {get; set;}

	}
}
