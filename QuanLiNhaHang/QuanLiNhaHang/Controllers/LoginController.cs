using Model.Dao;
using QuanLiNhaHang.Common;
using QuanLiNhaHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Session[CommonContants.TaiKhoan_SESSION] = null;

            return View();
        }
       
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new TaiKhoanDao();
                var result = dao.Login(model.MaTaiKhoan, model.Password);
                if (result == 1 )
                {
                    var nv = dao.GetByID(model.MaTaiKhoan);
                    var nvSession = new UserLogin();
                    nvSession.MaTaiKhoan = nv.MaTaiKhoan;
                    nvSession.Hoten = nv.HoTen;
                    nvSession.MaChucVu = nv.MaChucVu;
                    Session.Add(CommonContants.TaiKhoan_SESSION, nvSession);
                    if (nv.MaChucVu == "CV02")
                    return RedirectToAction("Index", "Manager/Home");
                    else if(nv.MaChucVu=="CV03")
                    return RedirectToAction("Index", "Employee/Home");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "Mã nhân viên không tồn tại");

                }
                else if(result == -1)
                {
                    ModelState.AddModelError("", "Mã nhân viên đã ngừng sử dụng");
                }
                else
                {
                    ModelState.AddModelError("", "Mật khẩu nhập vào không đúng");
                }
            }
         
            return View("Index");         
        }
    }
}