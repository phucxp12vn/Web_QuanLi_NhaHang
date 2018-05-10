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

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public bool? STATUS { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MonAn MonAn { get; set; }
    }
}
