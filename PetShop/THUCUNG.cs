namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THUCUNG")]
    public partial class THUCUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THUCUNG()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
        }

        [Key]
        [StringLength(5)]
        public string MATC { get; set; }

        [StringLength(5)]
        public string MACN { get; set; }

        [Required]
        [StringLength(10)]
        public string TEN { get; set; }

        public int TUOI { get; set; }

        [Required]
        [StringLength(30)]
        public string GIONG { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }
    }
}
