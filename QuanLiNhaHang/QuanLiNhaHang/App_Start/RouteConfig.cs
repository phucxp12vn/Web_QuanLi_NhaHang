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
<<<<<<< HEAD
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //Tim kiem nv          
=======
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");          
>>>>>>> 1a5849edc2281ea28ad029556fab3ff509caacfd
            //routes.MapRoute(
            //"Find",                                              // Route name
            //"{controller}/{action}/{TenNV}/{MaCV}",                           // URL with parameters
            //new { controller = "NhanVien", action = "Index", TenNV = "", MaCV = "", DiaChi = "", Sdt = "", Ngay = "", Stt = "" }  // Parameter defaults
            //     );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Index", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
