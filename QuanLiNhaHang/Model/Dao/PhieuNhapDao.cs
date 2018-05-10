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

        public List<NhaCungCap> ListAllNCC()
        {
            return db.NhaCungCaps.ToList();
        }

        public List<NhanVien> ListAllNV()
        {
            return db.NhanViens.ToList();
        }

        public string Insert(PhieuNhap phieu)
        {
            db.PhieuNhaps.Add(phieu);
            db.SaveChanges();
            return phieu.MaPhieuNhap;
        }


        public IEnumerable<PhieuNhap> ListAllPaging(string MaPhieuNhap, string MaNV, string MaNCC, Nullable<DateTime> NgayLap, int page, int pagesize)
        {
            IQueryable<PhieuNhap> model = db.PhieuNhaps;
            if (!string.IsNullOrEmpty(MaPhieuNhap))
            {
                model = model.Where(x => x.MaPhieuNhap.Contains(MaPhieuNhap));
            }
            if (!string.IsNullOrEmpty(MaNV))
            {
                model = model.Where(x => x.MaNV.Contains(MaNV));
            }
            //if (Stt == 1 || Stt != 0)
            //{
            //    model = model.Where(x => x.Status == true);
            //}
            //else model = model.Where(x => x.Status == false);
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
                tempt.MaNV= phieu.MaNV;
                tempt.MaNCC = phieu.MaNCC;
                tempt.NgayLapPhieu = phieu.NgayLapPhieu;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string MaPhieuNhap)
        {
            try
            {
                var phieu = db.PhieuNhaps.Find(MaPhieuNhap);
                db.PhieuNhaps.Remove(phieu);
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
