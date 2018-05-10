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
    public class MatHangController : Controller
    {
        // GET: Manager/MonAn
        public ActionResult Index(string TenMatHang, string MaDVT, Nullable<decimal> Gia, Nullable<int> SLC, int page = 1, int pagesize = 10)
        {
            var dao = new MatHangDao();
            MatHangModelView model = new MatHangModelView();
            model.list = (IPagedList<MatHang>)dao.ListAllPaging(TenMatHang, MaDVT, Gia, SLC, page, pagesize);
            ViewBag.TenTimKiem = TenMatHang;
            ViewBag.MaDVT = MaDVT;
            ViewBag.Gia = Gia;
            ViewBag.SLC = SLC ;
            SetViewBag(MaDVT);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }



        [HttpPost]
        public ActionResult Create(MatHang hang)
        {
            if (ModelState.IsValid)
            {
                var dao = new MatHangDao();
                hang.HanSuDung = DateTime.Now;
                string result = dao.Insert(hang);
                if (result != null)
                {
                    return RedirectToAction("Index", "MatHang");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm loại hàng mới thành công");
                }
            }
            return View("Index");
        }

        // Drop Down
        public void SetViewBag(string selectedId = null)
        {
            var dao = new MatHangDao();
            ViewBag.MaDVT = new SelectList(dao.ListAll(), "MaDVT", "MaDVT", selectedId);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var hang = new MatHangDao().GetByID(id);
            SetViewBag(hang.MaDVT);
            return View(hang);
        }


        [HttpPost]
        public ActionResult Edit(MatHang hang)
        {
            //nv.Status = true;
            if (ModelState.IsValid)
            {
                var dao = new MatHangDao();
                bool result = dao.Update(hang);
                if (result)
                {
                    return RedirectToAction("Index", "MatHang");
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
            new MatHangDao().Delete(id);
            return RedirectToAction("Index", "MatHang");
        }
    }
}