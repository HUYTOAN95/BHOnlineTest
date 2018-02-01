namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_khachhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bh_khachhang()
        {
            bh_hoadon = new HashSet<bh_hoadon>();
        }

        [Key]
        [StringLength(10)]
        public string Ma { get; set; }

        [StringLength(50)]
        public string Ten { get; set; }

        [StringLength(5)]
        public string Gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [Column(TypeName = "text")]
        public string SDT { get; set; }

        [Column(TypeName = "text")]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_hoadon> bh_hoadon { get; set; }
    }
}
