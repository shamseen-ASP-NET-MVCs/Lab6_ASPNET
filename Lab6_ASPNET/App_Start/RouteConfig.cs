using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab6_ASPNET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(  //have to pass in everything as Action?parameter1&parameter2 ...
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(  //now we can access welcome as HelloWorld/Welcome/Shamseen/1
                name: "Welcome",
                url: "{controller}/{action}/{name}/{id}"
                );
        }
    }
}
