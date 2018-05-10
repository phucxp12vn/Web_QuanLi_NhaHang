namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            MatHangs = new HashSet<MatHang>();
        }

        [Key]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [StringLength(100)]
        public string TenNCC { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DienThoai { get; set; }

        public bool? STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
