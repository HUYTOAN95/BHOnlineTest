namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_tt_xemay
    {
        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string TenCX { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string BKS { get; set; }

        [StringLength(50)]
        public string SoKhung { get; set; }

        [StringLength(50)]
        public string SoMay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHH { get; set; }

        public virtual bh_sanpham bh_sanpham { get; set; }
    }
}
