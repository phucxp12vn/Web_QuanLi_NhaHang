using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.ViewModel;
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
        public List<ChitiethoadonView> chitiethoadonview(string s)
        {
            
            var model = (from a in db.MonAns
                         join b in db.ChiTietHoaDons on a.MaMonAn equals b.MaMonAn
                         where b.MaHD.Contains(s)
                         select new ChitiethoadonView()
                         {
                             mahd = b.MaHD,
                             mamonan = b.MaMonAn,
                             tenmonan = a.TenMon,
                             gia = a.Gia,
                             soluong = b.SoLuong,
                             thanhtien = b.ThanhTien,
                             
                         }
                       );
            return model.ToList();
        }
    }
}
