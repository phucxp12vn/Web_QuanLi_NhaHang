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
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<GiamGia> GiamGias { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<MonAN> MonANs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhomMonAN> NhomMonANs { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
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

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.MucLuong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChucVu>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.ChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonViTinh>()
                .Property(e => e.MaDVT)
                .IsUnicode(false);

            modelBuilder.Entity<DonViTinh>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.DonViTinh)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GiamGia>()
                .Property(e => e.MaGiamGia)
                .IsUnicode(false);

            modelBuilder.Entity<GiamGia>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.GiamGia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NVLap)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBan)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaGiamGia)
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

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.MaKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.ChiTietKhuyenMais)
                .WithRequired(e => e.KhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaDVT)
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

            modelBuilder.Entity<MonAN>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<MonAN>()
                .Property(e => e.MaNhomMon)
                .IsUnicode(false);

            modelBuilder.Entity<MonAN>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonAN>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.MonAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAN>()
                .HasMany(e => e.ChiTietKhuyenMais)
                .WithRequired(e => e.MonAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAN>()
                .HasMany(e => e.ThanhPhans)
                .WithRequired(e => e.MonAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DienThoai)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .HasForeignKey(e => e.NVLap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhomMonAN>()
                .Property(e => e.MaNhomMon)
                .IsUnicode(false);

            modelBuilder.Entity<NhomMonAN>()
                .HasMany(e => e.MonANs)
                .WithRequired(e => e.NhomMonAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.KhuyenMai)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietKhuyenMai>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietKhuyenMai>()
                .Property(e => e.MaKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThanhPhan>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<ThanhPhan>()
                .Property(e => e.MaMatHang)
                .IsUnicode(false);
        }
    }
}
