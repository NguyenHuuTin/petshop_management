namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        public int? QUYEN { get; set; }
    }
}
