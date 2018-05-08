namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaMatHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaPhieuNhap { get; set; }

        public int? Soluong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        public DateTime? NgayNhan { get; set; }

        public bool? STATUS { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
