using QuanLiNhaHang.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuanLiNhaHang.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            UserLogin session = (UserLogin) Session[CommonContants.TaiKhoan_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                   RouteValueDictionary(new { controller = "../Login", action = "Index" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}