using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuanLiNhaHang.Common;
using System.Web.Mvc;
using Model.Dao;
using QuanLiNhaHang.Models;
using QuanLiNhaHang.Areas.Employee.Common;
using Model.EF;
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
        public ActionResult Chitiethoadon()
        {
            return View();
        }
        public ActionResult Hoadon()
        {
            var model = (UserLogin)Session[CommonContants.TaiKhoan_SESSION];
            var cv = model.MaChucVu;
            var user = model.MaTaiKhoan;
            if (cv == "CV03")
            {
                var hd = new HoadonModel();
                hd.MaNhanVien = user;
                hd.NgayLap = DateTime.Now.ToString("dd-MM-yyyy");
                return View((object)hd);
            }
            return View("~/View/Login/Index.cshtml");
        }
        public ActionResult TaoHoadon(HoadonModel hd)
        {
            
            var model = (UserLogin)Session[CommonContants.TaiKhoan_SESSION];
            var cv = model.MaChucVu;
            var user = model.MaTaiKhoan;
            if (cv == "CV03")
            {
                if (ModelState != null)
                {
                    var result = new HoaDonDao();
                    var hd1 = new HoaDon();
                    hd1.MaBan = hd.MaBan;
                    hd1.MaHD = hd.MaHoaDon;
                    hd1.MaTaiKhoan = hd.MaNhanVien;
                    IFormatProvider mFomatter = new System.Globalization.CultureInfo("en-US");
                    hd1.NgayLap = DateTime.Now;
                    hd1.GioVao = hd.GioVao;
                    hd1.GioThanhToan = hd.GioThanhToan;
                    hd1.STATUS = true;
                    var id = result.insert(hd1);
                    if (id != null)
                    {
                        HoaDonSave hds = new HoaDonSave();
                        hds.mahd = hd1.MaHD;
                        hds.maban = hd1.MaBan;
                        Session.Add(EmployeeConstant.mahd, hds);
                        return RedirectToAction("Chitiethoadon", "Home", "Employee");
                    }
                }
                else ModelState.AddModelError("", "Mời nhập đủ thông tin");
            }
            return View("~/View/Login/Index.cshtml");
        }
    }
}