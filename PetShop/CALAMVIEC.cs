namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CALAMVIEC")]
    public partial class CALAMVIEC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string BUOI { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NGAY { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string MANV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
