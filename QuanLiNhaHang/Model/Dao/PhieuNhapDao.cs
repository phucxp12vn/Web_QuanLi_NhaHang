using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class PhieuNhapDao
    {
        QuanLiNhaHangDbContext db = null;
        public PhieuNhapDao()
        {
            db = new QuanLiNhaHangDbContext();
        }

        public List<TaiKhoan> ListAllNV()
        {
            return db.TaiKhoans.ToList();
        }

        public string Insert(PhieuNhap phieu)
        {
            db.PhieuNhaps.Add(phieu);
            db.SaveChanges();
            return phieu.MaPhieuNhap;
        }


        public IEnumerable<PhieuNhap> ListAllPaging(string MaPhieuNhap, string MaTaiKhoan,  Nullable<DateTime> NgayLap, Nullable<int> Stt, int page, int pagesize)
        {
            IQueryable<PhieuNhap> model = db.PhieuNhaps;
            if (!string.IsNullOrEmpty(MaPhieuNhap))
            {
                model = model.Where(x => x.MaPhieuNhap.Contains(MaPhieuNhap));
            }
            if (!string.IsNullOrEmpty(MaTaiKhoan))
            {
                model = model.Where(x => x.MaTaiKhoan.Contains(MaTaiKhoan));
            }
            if (Stt == 1 || Stt != 0)
            {
                model = model.Where(x => x.STATUS == true);
            }
            else model = model.Where(x => x.STATUS == false);
            if (NgayLap != null)
            {
                DateTime day = (DateTime)NgayLap;
                model = model.Where(x => x.NgayLapPhieu == day);
            }
            return model.OrderByDescending(x => x.NgayLapPhieu).ToPagedList(page, pagesize);
        }

        public PhieuNhap GetByID(string MaPhieuNhap)
        {
            return db.PhieuNhaps.SingleOrDefault(x => x.MaPhieuNhap == MaPhieuNhap);
        }

        public bool Update(PhieuNhap phieu)
        {
            try
            {
                var tempt = db.PhieuNhaps.Find(phieu.MaPhieuNhap);
                tempt.MaTaiKhoan = phieu.MaTaiKhoan;
                tempt.NgayLapPhieu = phieu.NgayLapPhieu;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Lock(string MaPhieuNhap)
        {
            try
            {
                var tempt = db.PhieuNhaps.Find(MaPhieuNhap);
                tempt.STATUS = false;
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
