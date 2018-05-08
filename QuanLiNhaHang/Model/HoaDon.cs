namespace Model
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
        public string TKLap { get; set; }

        [Required]
        [StringLength(50)]
        public string MaBan { get; set; }

        public DateTime? NgayLap { get; set; }

        public TimeSpan? GioVao { get; set; }

        public TimeSpan? GioThanhToan { get; set; }

        public bool? STATUS { get; set; }

        public virtual Ban Ban { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
