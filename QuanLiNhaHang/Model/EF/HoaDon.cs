namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(50)]
        public string NVLap { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaGiamGia { get; set; }

        public DateTime NgayLap { get; set; }

        public TimeSpan GioVao { get; set; }

        public TimeSpan GioThanhToan { get; set; }

        public virtual Ban Ban { get; set; }

        public virtual GiamGia GiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}