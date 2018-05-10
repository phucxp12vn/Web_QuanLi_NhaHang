using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLiNhaHang.Areas.Manager.Models.ChiTietThanhPhan
{
    public class ThanhPhanModel : ThanhPhan
    {
        [StringLength(50)]
        public string MaNhomMon { get; set; }

        public PagedList<ThanhPhan> list { get; set; }
        public PagedList<MonAN> listmonan { get; set; }

    }
}