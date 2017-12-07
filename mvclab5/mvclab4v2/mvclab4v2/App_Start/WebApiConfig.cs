using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http.Headers;

namespace mvclab4v2.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                    name: "WApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}