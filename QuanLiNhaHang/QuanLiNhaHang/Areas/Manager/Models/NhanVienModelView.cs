using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiNhaHang.Areas.Manager.Models
{
    public class NhanVienModelView : NhanVien
    {
        public IPagedList<NhanVien> list { get; set; }
    }
}