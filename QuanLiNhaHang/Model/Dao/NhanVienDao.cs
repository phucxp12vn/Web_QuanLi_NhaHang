﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
   public class NhanVienDao
    {
        QuanLiNhaHangDbContext db = null;
        public NhanVienDao()
        {
            db = new QuanLiNhaHangDbContext();
        }

        public List<ChucVu> ListAll()
        {
            return db.ChucVus.ToList();
        }

        public string Insert(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
            return nv.MaNV;
        }

        public bool Update(NhanVien nv)
        {
            try
            {
                var tempt = db.NhanViens.Find(nv.MaNV);
                tempt.TenNV = nv.TenNV;
                tempt.MaChucVu = nv.MaChucVu;
                tempt.Sdt = nv.Sdt;
                tempt.DiaChi = nv.DiaChi;
                tempt.Status = nv.Status;
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
                var tempt = db.NhanViens.Find(MaNV);
                tempt.Status = false;
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<NhanVien> ListAllPaging(string TenNV, string MaCV, string DiaChi, string Sdt, Nullable<DateTime>  ngay, Nullable<int> Stt ,int page, int pagesize )
        {
            IQueryable<NhanVien> model = db.NhanViens;
            if(!string.IsNullOrEmpty(TenNV))
            {
                model = model.Where(x => x.MaNV.Contains(TenNV) || x.TenNV.Contains(TenNV));
            }
            if (!string.IsNullOrEmpty(MaCV))
            {
                model = model.Where(x => x.MaChucVu.Contains(MaCV) );
            }
            if (Stt == 1 || Stt != 0)
            {
                model = model.Where(x => x.Status == true);
            }
            else model = model.Where(x => x.Status == false);
            if (!string.IsNullOrEmpty(DiaChi))
            {
                model = model.Where(x => x.DiaChi.Contains(DiaChi));
            }
            if (!string.IsNullOrEmpty(Sdt))
            {
                model = model.Where(x => x.Sdt.Contains(Sdt));
            }
            if (ngay != null)
            {
                DateTime day = (DateTime)ngay;
                model = model.Where(x => x.NgayTao == day);
                    }
            return model.OrderByDescending(x => x.NgayTao).ToPagedList(page,pagesize);
        }


        public NhanVien GetByID(string MaNV)
        {
            return db.NhanViens.SingleOrDefault(x => x.MaNV == MaNV);
        }

        public int Login (string userName, string passWord)
        {
            var result = db.NhanViens.SingleOrDefault(x => x.MaNV == userName);
            if (result == null)

                return 0;
            else
            {
                if (result.Status == false) return -1;
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
                var nv = db.NhanViens.Find(MaNV);
                db.NhanViens.Remove(nv);
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
