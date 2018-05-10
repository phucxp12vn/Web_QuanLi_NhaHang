using Model.Dao;
using Model.EF;
using PagedList;
using QuanLiNhaHang.Areas.Manager.Models;
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
        public ActionResult Index(string TenNV, string MaCV, string DiaChi, string Sdt, Nullable<DateTime> ngay, Nullable<int> Stt,int page = 1, int pagesize = 10)
        {
            var dao = new NhanVienDao();
            NhanVienModelView model = new NhanVienModelView();
            model.list = (IPagedList<NhanVien>)dao.ListAllPaging(TenNV, MaCV, DiaChi, Sdt, ngay, Stt, page, pagesize);
            ViewBag.TenTimKiem = TenNV;
            ViewBag.MaCV = MaCV;
            ViewBag.DiaChi = DiaChi;
            ViewBag.Sdt = Sdt;
            ViewBag.day = ngay;
            ViewBag.Stt = Stt;
            SetViewBag(MaCV);
            return View(model);
        }

       

        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }



        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            if (ModelState.IsValid)
            {
                var dao = new NhanVienDao();
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


        // Drop Down
        public void SetViewBag(string selectedId = null)
        {
            var dao = new NhanVienDao();
            ViewBag.MaChucVu = new SelectList(dao.ListAll(), "MaChucVu", "MaChucVu", selectedId);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var nv = new NhanVienDao().GetByID(id);
            SetViewBag(nv.MaChucVu);
            return View(nv);
        }

      
        [HttpPost]
        public ActionResult Edit(NhanVien nv)
        {
            nv.Status = true;
            if (ModelState.IsValid)
            {
                var dao = new NhanVienDao();
                bool result = dao.Update(nv);
                if (result)
                {
                    return RedirectToAction("Index", "NhanVien");
                }
                else
                {
                    ModelState.AddModelError("", "Thay đổi thông tin không thành công");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            new NhanVienDao().Khoa(id);
            return RedirectToAction("","NhanVien");
        }

        [ChildActionOnly]
        public ActionResult _Profile_Info()
        {
            UserLogin session = (UserLogin)Session[CommonContants.NHANVIEN_SESSION];
            var model = session;
            return PartialView(model);
        }

    }
}