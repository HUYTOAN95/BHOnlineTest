namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_nhomsp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bh_nhomsp()
        {
            bh_sanpham = new HashSet<bh_sanpham>();
        }

        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [StringLength(100)]
        public string Hinh { get; set; }

        [StringLength(100)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_sanpham> bh_sanpham { get; set; }
    }
}
