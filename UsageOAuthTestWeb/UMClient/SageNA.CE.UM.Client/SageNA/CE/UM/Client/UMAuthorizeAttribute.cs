﻿// Type: SageNA.CE.UM.Client.UMAuthorizeAttribute
// Assembly: SageNA.CE.UM.Client, Version=1.0.5055.39667, Culture=neutral, PublicKeyToken=null
// MVID: 0CBFC6F9-9455-4507-975E-C4647329034D
// Assembly location: D:\SFAO User Management\CEWebDemo\CEWebDemo\UsageOAuthTestWeb\dependencies\SageNA.CE.UM.Client.dll

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SageNA.CE.UM.Client
{
  public class UMAuthorizeAttribute : AuthorizeAttribute
  {
    protected override bool AuthorizeCore(HttpContextBase httpContext)
    {
      return SSOSession.Refresh(httpContext);
    }

    public override void OnAuthorization(AuthorizationContext filterContext)
    {
      base.OnAuthorization(filterContext);
      if (filterContext.Result is HttpUnauthorizedResult && !SSOSession.HasSession(filterContext.HttpContext))
      {
        WebSessionAccessHelper.Reset(filterContext.HttpContext);
        filterContext.Result = (ActionResult) new RedirectToRouteResult(new RouteValueDictionary()
        {
          {
            "controller",
            (object) "SSO"
          },
          {
            "action",
            (object) "SignOnInit"
          }
        });
        WebSessionAccessHelper.SetSSOOriginalRequestUrl(filterContext.HttpContext, UriHelper.ToAbsoluteUri(ConfigHelper.DefaultConfig, filterContext.HttpContext, filterContext.HttpContext.Request.RawUrl).ToString());
      }
      else
        WebSessionAccessHelper.SetSSOOriginalRequestUrl(filterContext.HttpContext, string.Empty);
    }
  }
}
