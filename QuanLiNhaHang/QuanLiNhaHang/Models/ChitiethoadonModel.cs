using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuanLiNhaHang.Models
{
    public class ChitiethoadonModel
    {
        [Required (ErrorMessage ="mời nhập mã món ăn")]
        public string MaMonAn { get; set; }
        [Required(ErrorMessage = "mời nhập số lượng")]
        public int soluong { get; set; }
        public decimal thanhtien { get; set; }
    }
}