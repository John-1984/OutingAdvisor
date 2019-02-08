using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Outing_Advisor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Start",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Start", action = "Start", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Location",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Location", action = "Location", id = UrlParameter.Optional }

            routes.MapRoute(
                name: "Location",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Location", action = "Location", id = UrlParameter.Optional }
            );
        }
    }
}