using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // http://網址/temp_label/upload_labeltxt.asp 轉換到 ==>首頁
            //web config 需添加< !--< modules runAllManagedModulesForAllRequests = "true" > -->
            //routes.MapRoute(
            //  name: "Test1",
            //  url: "temp_label/upload_labeltxt.asp",
            //  defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
