namespace Model.EF
{
    using PagedList;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAN")]
    public partial class MonAN 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAN()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ChiTietKhuyenMais = new HashSet<ChiTietKhuyenMai>();
            ThanhPhans = new HashSet<ThanhPhan>();
        }

        [Key]
        [StringLength(50)]
        public string MaMonAn { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhomMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }

        public virtual NhomMonAN NhomMonAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhPhan> ThanhPhans { get; set; }

        IPagedList<Model.EF.MonAN> list { get; set; }

    }
}
