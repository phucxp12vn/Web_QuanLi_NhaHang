using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.Dao
{
    public class ChitiethoadonDao
    {
        QuanLiNhaHangDbContext db = null;
        public ChitiethoadonDao()
        {
            db = new QuanLiNhaHangDbContext();
        }
        public string insert(ChiTietHoaDon ct)
        {
            db.ChiTietHoaDons.Add(ct);
            db.SaveChanges();
            return ct.MaHD;
        }
        public decimal? timdongia(string m)
        {
            var model = (MonAn)db.MonAns.SingleOrDefault(x => x.MaMonAn == m);
            return model.Gia;
        }
    }
}
