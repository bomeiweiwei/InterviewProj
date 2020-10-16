using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MyWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 設定和服務

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "ServiceAreaApi",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional, Areas = "Service" }
            );

            config.Routes.MapHttpRoute(
               name: "Service_AreaApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional, Areas = "Service" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
