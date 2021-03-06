﻿// Type: SageSSO.ServiceReferences.GetAuthorizationsForClientRequest
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
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://sso.sage.com")]
  [GeneratedCode("svcutil", "3.0.4506.2152")]
  [DebuggerStepThrough]
  [Serializable]
  public class GetAuthorizationsForClientRequest
  {
    private Guid identityIdField;
    private string clientIdField;

    [XmlElement(Order = 0)]
    public Guid IdentityId
    {
      get
      {
        return this.identityIdField;
      }
      set
      {
        this.identityIdField = value;
      }
    }

    [XmlElement(Order = 1)]
    public string ClientId
    {
      get
      {
        return this.clientIdField;
      }
      set
      {
        this.clientIdField = value;
      }
    }
  }
}
