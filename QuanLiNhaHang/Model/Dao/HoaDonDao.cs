using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class HoaDonDao
    {
        QuanLiNhaHangDbContext db = null;
        public HoaDonDao()
        {
            db = new QuanLiNhaHangDbContext();
        }
        public string insert(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
            return hd.MaHD;
        }
        public bool kiemtraban(string s)
        {
            var model =(Ban)db.Bans.Where(x => x.MaBan == s);
            model.STATUS = false;
            return true;
        }
    }
}
