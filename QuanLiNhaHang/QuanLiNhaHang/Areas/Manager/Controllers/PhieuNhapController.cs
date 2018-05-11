using Model.Dao;
using Model.EF;
using PagedList;
using QuanLiNhaHang.Areas.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Manager.Controllers
{
    public class PhieuNhapController : Controller
    {
        // GET: Manager/PhieuNhap
        public ActionResult Index(string MaPhieuNhap, string MaTaiKhoan, Nullable<DateTime> NgayLap, Nullable<int> Stt, int page = 1, int pagesize = 10)
        {
            var dao = new PhieuNhapDao();
            PhieuNhapModelView model = new PhieuNhapModelView();
            model.list = (IPagedList<PhieuNhap>)dao.ListAllPaging(MaPhieuNhap, MaTaiKhoan, NgayLap, Stt,page, pagesize);
            ViewBag.TenTimKiem = MaPhieuNhap;
            ViewBag.NgayLap = NgayLap;
            SetViewBagMaNV(MaTaiKhoan);
            return View(model);
        }


        [HttpGet]
        public ActionResult Create()
        {
            var model = new PhieuNhap();
            model.NgayLapPhieu = DateTime.Now;
            return View(model);
        }



        [HttpPost]
        public ActionResult Create(PhieuNhap phieu)
        {
            if (ModelState.IsValid)
            {
                phieu.STATUS = true;
                var dao = new PhieuNhapDao();
                string result = dao.Insert(phieu);
                if (result != null)
                {
                    return RedirectToAction("Index", "PhieuNhap");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm phiếu nhập hàng mới thành công");
                }
            }
            return View("Index");
        }

        // Drop Down
        public void SetViewBagMaNV(string selectedId = null)
        {
            var dao = new PhieuNhapDao();
            ViewBag.MaTaiKhoan = new SelectList(dao.ListAllNV(), "MaTaiKhoan", "MaTaiKhoan", selectedId);
        }


        [HttpGet]
        public ActionResult Edit(string id)
        {
            var hang = new PhieuNhapDao().GetByID(id);
            SetViewBagMaNV(hang.MaTaiKhoan);
            return View(hang);
        }


        [HttpPost]
        public ActionResult Edit(PhieuNhap phieu)
        {
            //nv.Status = true;
            if (ModelState.IsValid)
            {
                var dao = new PhieuNhapDao();
                bool result = dao.Update(phieu);
                if (result)
                {
                    return RedirectToAction("Index", "PhieuNhap");
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
            new PhieuNhapDao().Lock(id);
            return RedirectToAction("Index", "PhieuNhap");
        }

    }
}