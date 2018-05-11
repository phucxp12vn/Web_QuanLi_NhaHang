using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class MonAnDao
    {
        QuanLiNhaHangDbContext db = null;
        public MonAnDao()
        {
            db = new QuanLiNhaHangDbContext();
        }

        public List<NhomMonAn> ListAllNhomMon()
        {
            return db.NhomMonAns.ToList();
        }

        public List<MatHang> ListAllMatHang()
        {
            return db.MatHangs.ToList();
        }

        public string Insert(MonAn mon)
        {
            db.MonAns.Add(mon);
            db.SaveChanges();
            return mon.MaMonAn;
        }

        public string Add(ThanhPhan thanhphan)
        {
            db.ThanhPhans.Add(thanhphan);
            db.SaveChanges();
            return thanhphan.MaMonAn;
        }

        public ThanhPhan KiemTraTonTai(ThanhPhan thanhphan)
        {
            return db.ThanhPhans.SingleOrDefault(x=>x.MaMatHang == thanhphan.MaMatHang && x.MaMonAn == thanhphan.MaMonAn);
        }

        public IEnumerable<MonAn> ListAllPaging(string MaMonAn, string MaNhomMon, Nullable<decimal> Gia,string thanhphan, Nullable<int> Stt,int page, int pagesize)
        {
            IQueryable<MonAn> model = db.MonAns;
            IQueryable<ThanhPhan> ThanhPhan = db.ThanhPhans;

            if (!string.IsNullOrEmpty(MaMonAn))
            {
                model = model.Where(x => x.MaMonAn.Contains(MaMonAn) || x.MaMonAn.Contains(MaMonAn));
            }
            if (!string.IsNullOrEmpty(MaNhomMon))
            {
                model = model.Where(x => x.MaNhomMon.Contains(MaNhomMon));
            }
            if (Stt == 1 || Stt != 0)
            {
                model = model.Where(x => x.STATUS == true);
            }
            else model = model.Where(x => x.STATUS == false);
            if (!string.IsNullOrEmpty(Gia.ToString()))
            {
                model = model.Where(x => x.Gia == Gia);
            }
            if(!string.IsNullOrEmpty(thanhphan))
            {
                ThanhPhan = ThanhPhan.Where(x => x.MaMatHang == thanhphan);
                model = from mon in model
                        join tp in ThanhPhan
                         on mon.MaMonAn equals tp.MaMonAn
                        select mon;
            }
            return model.OrderByDescending(x => x.MaMonAn).ToPagedList(page, pagesize);
        }

        public IEnumerable<ThanhPhan> ListDetail(string id, int page, int pagesize)
        {

            IQueryable<ThanhPhan> model = db.ThanhPhans;
            if (!string.IsNullOrEmpty(id))
            {
                model = model.Where(x => x.MaMonAn == id);
            }
            return model.OrderByDescending(x => x.MaMatHang).ToPagedList(page, pagesize);
        }

        public MonAn GetByID(string MaMonAn)
        {
            return db.MonAns.SingleOrDefault(x => x.MaMonAn == MaMonAn);
        }
        public ThanhPhan GetDetailByID(string MaMonAn,string MaMatHang)
        {
            var mon = db.ThanhPhans.SingleOrDefault(x => x.MaMatHang == MaMatHang && x.MaMonAn == MaMonAn);
            return mon;
        }

        public bool Update(MonAn mon)
        {
            try
            {
                var tempt = db.MonAns.Find(mon.MaMonAn);
                tempt.TenMon = mon.TenMon;
                tempt.MaNhomMon = mon.MaNhomMon;
                tempt.Gia= mon.Gia;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateDetail(ThanhPhan thanhphan)
        {
            try
            {
                ThanhPhan tempt = db.ThanhPhans.SingleOrDefault(m => m.MaMonAn == thanhphan.MaMonAn && m.MaMatHang == thanhphan.MaMatHang);
                tempt.MaMatHang = thanhphan.MaMatHang;
                tempt.SoLuong = thanhphan.SoLuong;
                tempt.GhiChu = thanhphan.GhiChu;
                Console.Write("");
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Lock(string MaMonAn)
        {
            try
            {
                var mon = db.MonAns.Find(MaMonAn);
                mon.STATUS = false;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteDetail(string MaMonAn,string MaMatHang)
        {
            try
            {
                var mon = db.ThanhPhans.SingleOrDefault(x => x.MaMatHang == MaMatHang && x.MaMonAn == MaMonAn);
                db.ThanhPhans.Remove(mon);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }

}
