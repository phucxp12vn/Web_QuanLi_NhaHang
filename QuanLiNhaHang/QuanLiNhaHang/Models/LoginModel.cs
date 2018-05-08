using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QuanLiNhaHang.Models
{
    public class LoginModel
    {
       // [Required(ErrorMessage = "Mời nhập user")]
        public string MaTaiKhoan { set; get; }
        //[Required(ErrorMessage = "Mời nhập password")]
        public string Password{ set; get; }
        
    }
}