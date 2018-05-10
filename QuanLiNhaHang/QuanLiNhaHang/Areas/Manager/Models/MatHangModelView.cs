using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiNhaHang.Areas.Manager.Models
{
    public class MatHangModelView : MatHang
    {
        public IPagedList<MatHang> list {get;set;}
    }
}