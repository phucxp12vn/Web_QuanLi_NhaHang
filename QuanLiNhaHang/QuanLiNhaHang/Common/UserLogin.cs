using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiNhaHang.Common
{
    [Serializable]
    public class UserLogin
    {       
        public string MaTaiKhoan { set; get; }
        public string Hoten { set; get; }
        public string MaChucVu { set; get; }
    }
}