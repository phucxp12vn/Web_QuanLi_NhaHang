using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLiNhaHang.Common;
using System.Web.Mvc;
using Model.Dao;
namespace QuanLiNhaHang.Areas.Employee.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Employee/Home
        public ActionResult Info()
        {
            
            var model = (UserLogin)Session[CommonContants.TaiKhoan_SESSION];
            var cv=model.MaChucVu;
            if (cv == "CV03")
            {
                var tk = new TaiKhoanDao();
                var result = tk.NhanvienInfo(model.MaTaiKhoan);
                return View(result);
            }
            return View("~/View/Login/Index.cshtml");
        }
    }
}