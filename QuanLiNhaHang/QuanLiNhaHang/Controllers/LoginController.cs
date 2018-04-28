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
            Session[CommonContants.NHANVIEN_SESSION] = null;

            return View();
        }
       
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new NhanVienDao();
                var result = dao.Login(model.MaNV, model.Password);
                if (result == 1 )
                {
                    var nv = dao.GetByID(model.MaNV);
                    var nvSession = new UserLogin();
                    nvSession.MaNV = nv.MaNV;
                    nvSession.TenNV = nv.TenNV;
                    nvSession.MaCV = nv.MaChucVu;
                    Session.Add(CommonContants.NHANVIEN_SESSION, nvSession);
                    if (nv.MaChucVu == "QL")
                    return RedirectToAction("Index", "Manager/Home");
                    else
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