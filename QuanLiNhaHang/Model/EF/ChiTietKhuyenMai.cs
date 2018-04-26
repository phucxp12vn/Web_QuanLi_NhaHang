namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietKhuyenMai")]
    public partial class ChiTietKhuyenMai
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaMonAn { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaKhuyenMai { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhanTram { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }

        public virtual MonAN MonAN { get; set; }
    }
}
