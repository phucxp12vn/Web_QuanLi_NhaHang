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

        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual MonAN MonAN { get; set; }
    }
}
