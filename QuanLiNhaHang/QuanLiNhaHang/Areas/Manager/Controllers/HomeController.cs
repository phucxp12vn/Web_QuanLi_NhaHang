using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Manager.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Manager/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}