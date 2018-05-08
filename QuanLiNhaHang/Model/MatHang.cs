namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
            ThanhPhans = new HashSet<ThanhPhan>();
        }

        [Key]
        [StringLength(50)]
        public string MaMatHang { get; set; }

        [Required]
        [StringLength(50)]
        public string MaDVT { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [StringLength(100)]
        public string TenMatHang { get; set; }

        public int? SoLuongCon { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaNhap { get; set; }

        public DateTime? HanSuDung { get; set; }

        public bool? STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        public virtual DonViTinh DonViTinh { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhPhan> ThanhPhans { get; set; }
    }
}
