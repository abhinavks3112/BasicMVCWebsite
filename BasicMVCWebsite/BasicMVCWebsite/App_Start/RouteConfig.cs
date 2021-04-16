using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BasicMVCWebsite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "EmployeeCreate",
              url: "Employee/Create",
              defaults: new { controller = "Employee", action = "Create", id = UrlParameter.Optional }
          );

            routes.MapRoute(
               name: "EmployeeEdit",
               url: "Employee/Edit/{id}",
               defaults: new { controller = "Employee", action = "Edit", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "EmployeeEditSave",
               url: "Employee/Save",
               defaults: new { controller = "Employee", action = "Save", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Employee",
                url: "Employee/Search",
                defaults: new { controller = "Employee", action = "Search", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AllEmployee",
                url: "Employee",
                defaults: new { controller = "Employee", action = "Index", name = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "DefaultTime",
                url: "Home",
                defaults: new { controller = "Home", action = "Time", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
