using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using Model.ViewModel;
using PagedList;

namespace Model.Dao
{
   public class TaiKhoanDao
    {
        QuanLiNhaHangDbContext db = null;
        public TaiKhoanDao()
        {
            db = new QuanLiNhaHangDbContext();
        }
        public List<NhanVienView> NhanvienInfo(string manv)
        {
            var model = (from a in db.TaiKhoans
                         join b in db.ChucVus 
                         on a.MaChucVu equals b.MaChucVu
                         where a.MaTaiKhoan.Contains(manv)
                         select new NhanVienView()
                         {
                             MaTaiKhoan = a.MaTaiKhoan,
                             HoTen=a.HoTen,
                             TenChucVu=b.TenChucVu,
                             Ngaytao=a.NgayTao
                         });
            return model.ToList();
        }
        public List<ChucVu> ListAll()
        {
            return db.ChucVus.ToList();
        }
        public string Insert(TaiKhoan nv)
        {
            db.TaiKhoans.Add(nv);
            db.SaveChanges();
            return nv.MaTaiKhoan;
        }
        //public List<>
        public bool Update(TaiKhoan nv)
        {
            try
            {
                var tempt = db.TaiKhoans.Find(nv.MaTaiKhoan);
                tempt.HoTen = nv.HoTen;
                tempt.MaChucVu = nv.MaChucVu;
                tempt.MatKhau = nv.MatKhau;
                tempt.NgayTao = nv.NgayTao;
                tempt.STATUS = nv.STATUS;
                db.SaveChanges();
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Khoa(string MaNV)
        {
            try
            {
                var tempt = db.TaiKhoans.Find(MaNV);
                tempt.STATUS = false;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<TaiKhoan> ListAllPaging(string TenNV, string MaCV, string DiaChi, string Sdt, Nullable<DateTime>  ngay, Nullable<int> Stt ,int page, int pagesize )
        {
            IQueryable<TaiKhoan> model = db.TaiKhoans;
            if(!string.IsNullOrEmpty(TenNV))
            {
                model = model.Where(x => x.MaTaiKhoan.Contains(TenNV) || x.HoTen.Contains(TenNV));
            }
            if (!string.IsNullOrEmpty(MaCV))
            {
                model = model.Where(x => x.MaChucVu.Contains(MaCV) );
            }
            if (Stt == 1 || Stt != 0)
            {
                model = model.Where(x => x.STATUS == true);
            }
            else model = model.Where(x => x.STATUS == false);
            //if (!string.IsNullOrEmpty(DiaChi))
            //{
            //    model = model.Where(x => x.DiaChi.Contains(DiaChi));
            //}
            //if (!string.IsNullOrEmpty(Sdt))
            //{
            //    model = model.Where(x => x.Sdt.Contains(Sdt));
            //}


            if (ngay != null)
            {
                DateTime day = (DateTime)ngay;
                model = model.Where(x => x.NgayTao == day);
                    }
            return model.OrderByDescending(x => x.NgayTao).ToPagedList(page,pagesize);
        }


        public TaiKhoan GetByID(string MaNV)
        {
            return db.TaiKhoans.SingleOrDefault(x => x.MaTaiKhoan == MaNV);
        }

        public int Login (string userName, string passWord)
        {
            var result = db.TaiKhoans.SingleOrDefault(x => x.MaTaiKhoan == userName);
            if (result == null)

                return 0;
            else
            {
                if (result.STATUS == false) return -1;
                else if (result.MatKhau == passWord)
                    return 1;
                else
                    return 2;
            }
        }

        public bool Delete(string MaNV)
        {
            try
            {
                var nv = db.TaiKhoans.Find(MaNV);
                db.TaiKhoans.Remove(nv);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
