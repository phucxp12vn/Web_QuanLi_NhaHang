namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuyenMai()
        {
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
        }

        [Key]
        [StringLength(50)]
        public string MaKhuyenMai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhuyenMai { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
    }
}
