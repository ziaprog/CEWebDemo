﻿// Type: SageSSO.ServiceReferences.CreateX509IdentityResponse
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SageSSO.ServiceReferences
{
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DesignerCategory("code")]
  [DebuggerStepThrough]
  [XmlType(Namespace = "http://sso.sage.com")]
  [Serializable]
  public class CreateX509IdentityResponse
  {
    private Guid idField;
    private long versionStampField;

    [XmlElement(Order = 0)]
    public Guid Id
    {
      get
      {
        return this.idField;
      }
      set
      {
        this.idField = value;
      }
    }

    [XmlElement(Order = 1)]
    public long VersionStamp
    {
      get
      {
        return this.versionStampField;
      }
      set
      {
        this.versionStampField = value;
      }
    }
  }
}
