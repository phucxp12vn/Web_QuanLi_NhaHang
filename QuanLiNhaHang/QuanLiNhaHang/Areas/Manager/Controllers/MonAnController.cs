using Model.Dao;
using Model.EF;
using PagedList;
using QuanLiNhaHang.Areas.Manager.Models.ChiTietThanhPhan;
using QuanLiNhaHang.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiNhaHang.Areas.Manager.Controllers
{
    public class MonAnController : Controller
    {
        // GET: Manager/MonAn
        public ActionResult Index(string TenMonAn, string MaNhomMon, Nullable<decimal> Gia,string MaMatHang, int page = 1, int pagesize = 10)
        {
            var dao = new MonAnDao();
            ThanhPhanModel mon = new ThanhPhanModel();
            mon.listmonan = (PagedList<MonAN>)dao.ListAllPaging(TenMonAn, MaNhomMon, Gia, MaMatHang, page, pagesize);
            ViewBag.TenTimKiem = TenMonAn;
            ViewBag.Gia = Gia;
            SetViewBagMaNhomMon(MaNhomMon);
            SetViewBagMatHang(MaMatHang);
            return View(mon);
        }

        public ActionResult Detail(string id, int page = 1, int pagesize = 10)
        {
            if (id != null)
            {
                var dao = new MonAnDao();
                ThanhPhanModel thanhphan = new ThanhPhanModel();
                thanhphan.MonAN = dao.GetByID(id);
                thanhphan.list = (PagedList<ThanhPhan>)dao.ListDetail(id, page, pagesize);
                return View(thanhphan);
            }
            return RedirectToAction("Index", "MonAn");
        }


        [HttpGet]
        public ActionResult Create()
        {
            SetViewBagMaNhomMon();
            return View();
        }



        [HttpPost]
        public ActionResult Create(MonAN mon)
        {
            if (ModelState.IsValid)
            {
                var dao = new MonAnDao();
                string result = dao.Insert(mon);
                if (result != null)
                {
                    return RedirectToAction("Add/" + mon.MaMonAn, "MonAn");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm món thất bại");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult Add(string id)
        {
            if (id != null)
            {
                ThanhPhan tp = new ThanhPhan();
                tp.MonAN = new MonAnDao().GetByID(id);
                SetViewBagMatHang();
                return View(tp);
            }
            return RedirectToAction("Index", "MonAn");
        }


        [HttpPost]
        public ActionResult Add(ThanhPhan thanhphan,string id)
        {
            //nv.Status = true;
            if (ModelState.IsValid)
            {
                SetViewBagMatHang();
                thanhphan.MaMonAn = id;
                var dao = new MonAnDao();
                ThanhPhan kt = dao.KiemTraTonTai(thanhphan);
                string result;
                if (kt == null)
                {
                   result = dao.Add(thanhphan);//Them moi 
                }
                else
                {
                    thanhphan.SoLuong = thanhphan.SoLuong + kt.SoLuong;
                    if(thanhphan.GhiChu == null)
                    {
                        thanhphan.GhiChu = kt.GhiChu;
                    }
                    result =  dao.UpdateDetail(thanhphan).ToString();
                }
                if (result != null)
                {
                    return RedirectToAction("Add", "MonAn", id);

                }
                else
                {
                    ModelState.AddModelError("", "Thêm nguyên liệu không thành công");
                }
            }
            return View("Index");
        }



        // Drop Down
        public void SetViewBagMaNhomMon(string selectedId = null)
        {
            var dao = new MonAnDao();
            ViewBag.MaNhomMon= new SelectList(dao.ListAllNhomMon(), "MaNhomMon", "TenNhomMon", selectedId);
        }

        public void SetViewBagMatHang(string selectedId = null)
        {
            var dao = new MonAnDao();
            ViewBag.MaMatHang = new SelectList(dao.ListAllMatHang(), "MaMatHang", "TenMatHang", selectedId);

        }

        [HttpGet]
        public ActionResult Edit(string id, int page = 1, int pagesize = 10)
        {
            if (id != null)
            {
                var dao = new MonAnDao();
            ThanhPhanModel thanhphan = new ThanhPhanModel();
            if (!string.IsNullOrEmpty(id))
            {
                thanhphan.MonAN = dao.GetByID(id);
                thanhphan.list = (PagedList<ThanhPhan>)dao.ListDetail(id, page, pagesize);
                thanhphan.MaNhomMon = thanhphan.MonAN.MaNhomMon;
                SetViewBagMaNhomMon(thanhphan.MaNhomMon);
            }
            return View(thanhphan);
        }
            return RedirectToAction("Index", "MonAn");
        }


        [HttpPost]
        public ActionResult Edit(ThanhPhanModel thanhphan)
        {

            if (!string.IsNullOrEmpty(thanhphan.MonAN.MaMonAn) && !string.IsNullOrEmpty(thanhphan.MaNhomMon))
            {
                var dao = new MonAnDao();
                thanhphan.MonAN.MaNhomMon = thanhphan.MaNhomMon;
                bool result = dao.Update(thanhphan.MonAN);             
                if (result)
                {
                    return RedirectToAction("Index", "MonAn");
                }
                else
                {
                    ModelState.AddModelError("", "Thay đổi thông tin không thành công");
                }
            }
            return View("Index");
        }

        [HttpGet]
        public ActionResult EditDetail(string MaMonAn, string MaMatHang)
        {

            if (MaMonAn != null && MaMatHang != null)
            {
                ThanhPhan tp = new ThanhPhan();
                var dao = new MonAnDao();
                tp.MonAN = dao.GetByID(MaMonAn);
                tp = dao.GetDetailByID(MaMonAn, MaMatHang);
                SetViewBagMatHang();
                return View(tp);
            }
            return RedirectToAction("Index", "MonAn");

        }


        [HttpPost]
        public ActionResult EditDetail(ThanhPhan thanhphan)
        {
            thanhphan.MaMonAn = thanhphan.MonAN.MaMonAn;
            //nv.Status = true;
            if (thanhphan.MaMatHang != null && thanhphan.MaMonAn != null )
            {
                var dao = new MonAnDao();
                ThanhPhan kt = dao.KiemTraTonTai(thanhphan);
                string result;
                if (kt == null)
                {
                    result = dao.Add(thanhphan).ToString();//Them moi 
                }
                else
                {
                    result = dao.UpdateDetail(thanhphan).ToString();
                    if(thanhphan.MaMatHang != thanhphan.MatHang.MaMatHang)
                    dao.DeleteDetail(thanhphan.MaMonAn, thanhphan.MatHang.MaMatHang);
                }
       

                if (result!=null)
                {
                    return RedirectToAction("Detail/" + thanhphan.MonAN.MaMonAn, "MonAn");
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
            new MonAnDao().Delete(id);
            return RedirectToAction("Index","MonAn");
        }

        [HttpDelete]
        public ActionResult DeleteDetail(string MaMonAn, string MaMatHang)
        {
            new MonAnDao().DeleteDetail(MaMonAn, MaMatHang);
            return RedirectToAction("Index", "MonAn");
        }

    }
}