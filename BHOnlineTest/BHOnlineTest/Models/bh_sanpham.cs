namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bh_sanpham()
        {
            bh_hoadon = new HashSet<bh_hoadon>();
        }

        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gia { get; set; }

        [StringLength(50)]
        public string Mota { get; set; }

        [StringLength(50)]
        public string Hinhanh { get; set; }

        [StringLength(10)]
        public string Manhom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_hoadon> bh_hoadon { get; set; }

        public virtual bh_nhomsp bh_nhomsp { get; set; }

        public virtual bh_tomtatsp bh_tomtatsp { get; set; }

        public virtual bh_tt_xemay bh_tt_xemay { get; set; }
    }
}
