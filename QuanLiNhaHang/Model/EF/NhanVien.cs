namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        [StringLength(50)]
        [Display(Name = "Mã Nhân Viên")]
        public string MaNV { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên Nhân Viên")]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mã Chức Vụ")]
        public string MaChucVu { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa Chỉ")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Số Điện Thoại")]
        public string Sdt { get; set; }

        public DateTime? NgayTao { get; set; }

        public bool? Status { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
