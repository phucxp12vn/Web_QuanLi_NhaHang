namespace Model.EF
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

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Soluong { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal DonGia { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime NgayNhan { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
