﻿// ReSharper disable All

namespace OpenTl.Schema.Channels
{
	using System;
	using System.Collections;
	using System.Text;

	using OpenTl.Schema;
	using OpenTl.Schema.Serialization.Attributes;	

	[Serialize(0xed8af74d)]
	public class TAdminLogResults : IAdminLogResults
	{
       [SerializationOrder(0)]
       public TVector<IChannelAdminLogEvent> Events {get; set;}

       [SerializationOrder(1)]
       public TVector<IChat> Chats {get; set;}

       [SerializationOrder(2)]
       public TVector<IUser> Users {get; set;}

	}
}