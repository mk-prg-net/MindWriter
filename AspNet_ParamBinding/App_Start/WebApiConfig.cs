using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNet_ParamBinding
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Registrierung des JSON Parsers für PArameter mit dem Namen **FilterList**
            config.ParameterBindingRules.Insert(0, Models.FilterListParameterBindingRule.GetRule);
        }
    }
}
