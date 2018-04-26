using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLiNhaHang
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");          
            routes.MapRoute(
            "Find",                                              // Route name
            "{controller}/{action}/{TenNV}/{MaCV}",                           // URL with parameters
            new { controller = "NhanVien", action = "Index", TenNV = "", MaCV = "" }  // Parameter defaults
                 );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
