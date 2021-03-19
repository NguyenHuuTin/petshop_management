namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CALAMVIECs = new HashSet<CALAMVIEC>();
            HOADONs = new HashSet<HOADON>();
            THUCUNGs = new HashSet<THUCUNG>();
        }

        [Key]
        [StringLength(5)]
        public string MANV { get; set; }

        [Required]
        [StringLength(20)]
        public string HO_TENNV { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        public int? LUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CALAMVIEC> CALAMVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCUNG> THUCUNGs { get; set; }
    }
}
