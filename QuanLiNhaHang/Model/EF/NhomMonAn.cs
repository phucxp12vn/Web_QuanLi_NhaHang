namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomMonAn")]
    public partial class NhomMonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomMonAn()
        {
            MonAns = new HashSet<MonAn>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhomMon { get; set; }

        [StringLength(50)]
        public string TenNhomMon { get; set; }

        public bool? STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAn> MonAns { get; set; }
    }
}
