namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_hoadon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }

        public int? Soluong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [StringLength(10)]
        public string Magiamgia { get; set; }

        public virtual bh_giamgia bh_giamgia { get; set; }

        public virtual bh_khachhang bh_khachhang { get; set; }

        public virtual bh_nhanvien bh_nhanvien { get; set; }

        public virtual bh_sanpham bh_sanpham { get; set; }
    }
}
