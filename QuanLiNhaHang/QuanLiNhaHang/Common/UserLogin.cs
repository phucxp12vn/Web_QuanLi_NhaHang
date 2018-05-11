using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiNhaHang.Common
{
    [Serializable]
    public class UserLogin
    {       
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public string MaCV { set; get; }
    }
}