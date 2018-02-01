namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_tomtatsp
    {
        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        public string Doituong { get; set; }

        public string Phamvi { get; set; }

        public string Loaitru { get; set; }

        public string Quyenloi { get; set; }

        public int? Thoihan { get; set; }

        public virtual bh_sanpham bh_sanpham { get; set; }
    }
}
