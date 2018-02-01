namespace BHOnlineTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bh_nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bh_nhanvien()
        {
            bh_hoadon = new HashSet<bh_hoadon>();
            bh_nsd = new HashSet<bh_nsd>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        [StringLength(5)]
        public string Gioitinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string Chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_hoadon> bh_hoadon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bh_nsd> bh_nsd { get; set; }
    }
}
