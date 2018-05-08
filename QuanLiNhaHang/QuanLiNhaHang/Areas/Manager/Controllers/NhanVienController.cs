using Model.Dao;
using Model.EF;
using QuanLiNhaHang.Common;
using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Manager.Controllers
{
    public class NhanVienController : BaseController
    {
        // GET: Manager/NhanVien
        public ActionResult Index(TaiKhoan nv,string TenNV, string MaCV, string DiaChi, string Sdt, Nullable<DateTime> ngay, Nullable<int> Stt,int page = 1, int pagesize = 10)
        {
            var dao = new TaiKhoanDao();
            var model = dao.ListAllPaging(TenNV, MaCV, DiaChi, Sdt, ngay, Stt, page, pagesize);
            ViewBag.TenTimKiem = TenNV;
            ViewBag.MaCV = MaCV;
            ViewBag.DiaChi = DiaChi;
            ViewBag.Sdt = Sdt;
            ViewBag.day = ngay;
            ViewBag.Stt = Stt;
            return View(model);
        }

       

        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }



        [HttpPost]
        public ActionResult Create(TaiKhoan nv)
        {
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanDao();
                string result = dao.Insert(nv);
                if (result != null)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm nhân viên mới không thành công");
                }
            }
            return View("Index");
        }



        public void SetViewBag(string selectedId = null)
        {
            var dao = new TaiKhoanDao();
            ViewBag.MaChucVu = new SelectList(dao.ListAll(), "MaChucVu", "TenChucVu", selectedId);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var nv = new TaiKhoanDao().GetByID(id);
            SetViewBag(nv.MaChucVu);
            return View(nv);
        }

      
        [HttpPost]
        public ActionResult Edit(TaiKhoan nv)
        {
            nv.STATUS = true;
            if (ModelState.IsValid)
            {
                var dao = new TaiKhoanDao();
                bool result = dao.Update(nv);
                if (result)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm nhân viên mới không thành công");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            new TaiKhoanDao().Khoa(id);
            return RedirectToAction("Index","NhanVien");
        }

        [ChildActionOnly]
        public ActionResult _Profile_Info()
        {
            UserLogin session = (UserLogin)Session[CommonContants.TaiKhoan_SESSION];
            var model = session;
            return PartialView(model);
        }

    }
}