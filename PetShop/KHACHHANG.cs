namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADONs = new HashSet<HOADON>();
            THUCUNGs = new HashSet<THUCUNG>();
        }

        [Key]
        [StringLength(5)]
        public string MAKH { get; set; }

        [Required]
        [StringLength(20)]
        public string HO_TENKH { get; set; }

        [Required]
        [StringLength(20)]
        public string DCKH { get; set; }

        [Required]
        [StringLength(10)]
        public string SDTKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THUCUNG> THUCUNGs { get; set; }
    }
}
