﻿using System.Web.Http;

// ReSharper disable CheckNamespace
namespace Saguaro
// ReSharper restore CheckNamespace
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
