using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CoffeeShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ShowHome",
                url: "Home/ShowHomePage",
                defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SignUp",
                url: "Home/SignUp",
                defaults: new { controller = "SignUp", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "Home/Login",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Menu",
               url: "Home/Menu",
               defaults: new { controller = "Menus", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
