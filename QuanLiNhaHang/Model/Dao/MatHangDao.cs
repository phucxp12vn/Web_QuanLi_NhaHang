using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.Dao
{
    public class MatHangDao
    {

        QuanLiNhaHangDbContext db = null;
        public MatHangDao()
        {
            db = new QuanLiNhaHangDbContext();
        }

        public List<DonViTinh> ListAllMaDVT()
        {
            return db.DonViTinhs.ToList();
        }

        public List<NhaCungCap> ListAllMaNCC()
        {
            return db.NhaCungCaps.ToList();
        }

        public string Insert(MatHang hang)
        {
            db.MatHangs.Add(hang);
            db.SaveChanges();
            return hang.MaMatHang;
        }


        public IEnumerable<MatHang> ListAllPaging(string MaMatHang, string MaDVT, string MaNCC, Nullable<decimal> Gia, Nullable<int> SLC, Nullable<int> Stt, int page, int pagesize)
        {
            IQueryable<MatHang> model = db.MatHangs;
            if (!string.IsNullOrEmpty(MaMatHang))
            {
                model = model.Where(x => x.MaMatHang.Contains(MaMatHang) || x.TenMatHang.Contains(MaMatHang));
            }
            if (!string.IsNullOrEmpty(MaDVT))
            {
                model = model.Where(x => x.MaDVT.Contains(MaDVT));
            }
            if (!string.IsNullOrEmpty(MaNCC))
            {
                model = model.Where(x => x.MaNCC.Contains(MaNCC));
            }
            if (Stt == 1 || Stt != 0)
            {
                model = model.Where(x => x.STATUS == true);
            }
            else model = model.Where(x => x.STATUS == false);
            if (!string.IsNullOrEmpty(Gia.ToString()))
            {
                model = model.Where(x => x.GiaNhap == Gia);
            }
            if (!string.IsNullOrEmpty(SLC.ToString()))
            {
                model = model.Where(x => x.SoLuongCon == SLC);
            }
            return model.OrderBy(x => x.MaMatHang).ToPagedList(page, pagesize);
        }

        public MatHang GetByID(string MaMatHang)
        {
            return db.MatHangs.SingleOrDefault(x => x.MaMatHang == MaMatHang);
        }

        public bool Update(MatHang hang)
        {
            try
            {
                var tempt = db.MatHangs.Find(hang.MaMatHang);
                tempt.TenMatHang = hang.TenMatHang;
                tempt.MaDVT= hang.MaDVT;
                tempt.GiaNhap = hang.GiaNhap;
                tempt.SoLuongCon = hang.SoLuongCon;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

   
        public bool Delete(string MaMatHang)
        {
            try
            {
                var hang = db.MatHangs.Find(MaMatHang);
                db.MatHangs.Remove(hang);
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
