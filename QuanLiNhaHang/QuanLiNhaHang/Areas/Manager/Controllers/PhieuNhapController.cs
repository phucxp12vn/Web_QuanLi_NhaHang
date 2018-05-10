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
        public ActionResult Index(string MaPhieuNhap, string MaNV, string MaNCC, Nullable<DateTime> NgayLap, int page = 1, int pagesize = 10)
        {
            var dao = new PhieuNhapDao();
            PhieuNhapModelView model = new PhieuNhapModelView();
            model.list = (IPagedList<PhieuNhap>)dao.ListAllPaging(MaPhieuNhap, MaNV, MaNCC, NgayLap, page, pagesize);
            ViewBag.TenTimKiem = MaPhieuNhap;
            ViewBag.NgayLap = NgayLap;
            SetViewBagMaNCC(MaNCC);
            SetViewBagMaNV(MaNV);
            return View(model);
        }


        [HttpGet]
        public ActionResult Create()
        {
            SetViewBagMaNCC();
            var model = new PhieuNhap();
            model.NgayLapPhieu = DateTime.Now;
            return View(model);
        }



        [HttpPost]
        public ActionResult Create(PhieuNhap phieu)
        {
            if (ModelState.IsValid)
            {
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
            ViewBag.MaNV = new SelectList(dao.ListAllNV(), "MaNV", "MaNV", selectedId);
        }

        public void SetViewBagMaNCC(string selectedId = null)
        {
            var dao = new PhieuNhapDao();
            ViewBag.MaNCC = new SelectList(dao.ListAllNCC(), "MaNCC", "TenNCC", selectedId);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var hang = new PhieuNhapDao().GetByID(id);
            SetViewBagMaNCC(hang.MaNCC);
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
            new PhieuNhapDao().Delete(id);
            return RedirectToAction("Index", "PhieuNhap");
        }

    }
}