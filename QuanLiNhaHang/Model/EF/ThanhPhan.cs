namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhPhan")]
    public partial class ThanhPhan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaMonAn { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaMatHang { get; set; }

<<<<<<< HEAD
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }
=======
        public int? SoLuong { get; set; }
>>>>>>> 1a5849edc2281ea28ad029556fab3ff509caacfd

        [StringLength(200)]
        public string GhiChu { get; set; }

        public bool? STATUS { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual MonAn MonAn { get; set; }
    }
}
