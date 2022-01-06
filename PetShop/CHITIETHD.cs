namespace PetShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHD")]
    public partial class CHITIETHD
    {
        [Key]
        public int MACT { get; set; }

        [StringLength(5)]
        public string MAHD { get; set; }

        [StringLength(5)]
        public string MADV { get; set; }

        [StringLength(5)]
        public string MATA { get; set; }

        public int? SOLUONG { get; set; }

        public int? DONGIA { get; set; }

        public int? T_TIEN { get; set; }

        public virtual DICHVU DICHVU { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual THUCAN THUCAN { get; set; }
    }
}
