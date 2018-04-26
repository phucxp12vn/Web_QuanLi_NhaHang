namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaMonAn { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuong { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal DonGia { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal KhuyenMai { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MonAN MonAN { get; set; }
    }
}
