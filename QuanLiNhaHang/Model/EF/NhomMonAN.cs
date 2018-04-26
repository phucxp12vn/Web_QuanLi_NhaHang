namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomMonAN")]
    public partial class NhomMonAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomMonAN()
        {
            MonANs = new HashSet<MonAN>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhomMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhomMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAN> MonANs { get; set; }
    }
}
