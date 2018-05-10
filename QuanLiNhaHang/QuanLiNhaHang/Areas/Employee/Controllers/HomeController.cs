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
        public ActionResult TaoChitiethoadon(ChitiethoadonModel ct)
        {
            var model = (HoaDonSave)Session[Common.EmployeeConstant.mahd];
            var s = model.mahd;
            if(ModelState.IsValid)
            {
                var model1 = new ChitiethoadonDao();
                var model2 = new ChiTietHoaDon();
                model2.MaHD = s;
                model2.MaMonAn = ct.MaMonAn;
                model2.SoLuong = ct.soluong;
                if (model2.MaMonAn == null)
                {
                    ModelState.AddModelError("", "Mời nhập mã món ăn");
                }
                else if (model2.SoLuong == null)
                {
                    ModelState.AddModelError("", "mời nhập số lượng món");
                }
                else
                {
                    var x = model1.timdongia(ct.MaMonAn);
                    model2.ThanhTien = (decimal)x * ct.soluong;
                    var result = model1.insert(model2);
                    if (result != null)
                    {
                        return RedirectToAction("Chitiethoadon", "Home", "Employee");
                    }
                }
                
            }
            return RedirectToAction("Chitiethoadon", "Home", "Employee");
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
        public ActionResult XuatHoaDon()
        {
            decimal? sum = 0;
            var model1 = new ChitiethoadonDao();
            var hd = (HoaDonSave)Session[Common.EmployeeConstant.mahd];
            var model=model1.chitiethoadonview(hd.mahd);
            foreach(var item in model)
            {
                sum = sum + item.thanhtien;
            }
            ViewBag.tongtien = sum;
            ViewBag.mahd = hd.mahd;
            return View(model);
        }
        public ActionResult TaoHoadon(HoadonModel hd)
        {
            
            var model = (UserLogin)Session[CommonContants.TaiKhoan_SESSION];
            var cv = model.MaChucVu;
            var user = model.MaTaiKhoan;
            if (cv == "CV03")
            {
                if (ModelState.IsValid)
                {
                    var result = new HoaDonDao();
                    var hd1 = new HoaDon();
                    hd1.MaBan = hd.MaBan;
                    hd1.MaHD = hd.MaHoaDon;
                    hd1.MaTaiKhoan = hd.MaNhanVien;
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