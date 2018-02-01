namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_giamgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bh_giamgia()
        {
            bh_hoadon = new HashSet<bh_hoadon>();
        }

        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(10)]
        public string Masp { get; set; }

        public double? GiamGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_hoadon> bh_hoadon { get; set; }
    }
}
