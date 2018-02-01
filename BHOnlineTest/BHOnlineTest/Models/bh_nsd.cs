namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_nsd
    {
        [Key]
        [StringLength(20)]
        public string Madn { get; set; }

        [StringLength(50)]
        public string Tendn { get; set; }

        public string Matkhau { get; set; }

        [StringLength(10)]
        public string Quyen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [StringLength(10)]
        public string Manv { get; set; }

        public virtual bh_nhanvien bh_nhanvien { get; set; }
    }
}
