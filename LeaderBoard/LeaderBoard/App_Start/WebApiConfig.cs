using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace LeaderBoard.App_Start
{
    public class WebApiConfig
    {
        public static void Register( HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                    name: "WApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
