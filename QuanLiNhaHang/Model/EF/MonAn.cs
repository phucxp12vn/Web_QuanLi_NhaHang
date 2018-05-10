namespace Model.EF
{
    using PagedList;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

<<<<<<< HEAD:QuanLiNhaHang/Model/EF/MonAN.cs
    [Table("MonAN")]
    public partial class MonAN 
=======
    [Table("MonAn")]
    public partial class MonAn
>>>>>>> 1a5849edc2281ea28ad029556fab3ff509caacfd:QuanLiNhaHang/Model/EF/MonAn.cs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            ThanhPhans = new HashSet<ThanhPhan>();
        }

        [Key]
        [StringLength(50)]
        public string MaMonAn { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhomMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        [StringLength(200)]
        public string IMG { get; set; }

        public bool? STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

<<<<<<< HEAD:QuanLiNhaHang/Model/EF/MonAN.cs
        public virtual NhomMonAN NhomMonAN { get; set; }
=======
        public virtual NhomMonAn NhomMonAn { get; set; }

>>>>>>> 1a5849edc2281ea28ad029556fab3ff509caacfd:QuanLiNhaHang/Model/EF/MonAn.cs
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhPhan> ThanhPhans { get; set; }

        IPagedList<Model.EF.MonAN> list { get; set; }

    }
}
