namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLiNhaHangDbContext : DbContext
    {
        public QuanLiNhaHangDbContext()
            : base("name=QuanLiNhaHangDbContext")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhomMonAn> NhomMonAns { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThanhPhan> ThanhPhans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<Ban>()
                .Property(e => e.MaKhu)
                .IsUnicode(false);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonViTinh>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.DonViTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuVuc>()
                .Property(e => e.MaKhu)
                .IsUnicode(false);

            modelBuilder.Entity<KhuVuc>()
                .HasMany(e => e.Bans)
                .WithRequired(e => e.KhuVuc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.GiaNhap)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThanhPhans)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaNhomMon)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.IMG)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.MonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ThanhPhans)
                .WithRequired(e => e.MonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DienThoai)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhomMonAn>()
                .Property(e => e.MaNhomMon)
                .IsUnicode(false);

            modelBuilder.Entity<NhomMonAn>()
                .HasMany(e => e.MonAns)
                .WithRequired(e => e.NhomMonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.ATM)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhPhan>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhPhan>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);
        }
    }
}
