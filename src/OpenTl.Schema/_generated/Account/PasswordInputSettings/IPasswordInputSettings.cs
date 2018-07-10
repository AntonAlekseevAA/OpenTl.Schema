﻿// ReSharper disable All

namespace OpenTl.Schema.Account
{
    using System;
	using System.Collections;

	using OpenTl.Schema;

    public interface IPasswordInputSettings : IObject
    {
       BitArray Flags {get; set;}

       byte[] NewSalt {get; set;}

       byte[] NewPasswordHash {get; set;}

       byte[] HintAsBinary {get; set;}
       string Hint {get; set;}

       byte[] EmailAsBinary {get; set;}
       string Email {get; set;}

       byte[] NewSecureSalt {get; set;}

       byte[] NewSecureSecret {get; set;}

       long NewSecureSecretId {get; set;}

    }
}
