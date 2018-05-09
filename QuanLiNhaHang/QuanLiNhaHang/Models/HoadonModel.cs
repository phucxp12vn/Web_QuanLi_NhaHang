using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QuanLiNhaHang.Models
{
    public class HoadonModel
    {
        [Key]
        [Required (ErrorMessage ="Nhập mã hóa đơn")]
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        [Required (ErrorMessage ="nhập mã bàn")]
        public string MaBan { get; set; }
        public string NgayLap { get; set; }
        public TimeSpan? GioVao { get; set; }
        public TimeSpan? GioThanhToan { get; set; }
    }
}