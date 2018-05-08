using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Employee.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Employee/Home
        public ActionResult Info()
        {
            return View();
        }
    }
}