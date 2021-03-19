namespace PetShop
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PetShopContext : DbContext
    {
        public PetShopContext()
            : base("name=PetShopContext")
        {
        }

        public virtual DbSet<CALAMVIEC> CALAMVIECs { get; set; }
        public virtual DbSet<CHITIETHD> CHITIETHDs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THUCAN> THUCANs { get; set; }
        public virtual DbSet<THUCUNG> THUCUNGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CALAMVIEC>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MACT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHD>()
                .Property(e => e.MATA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDTKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.THUCUNGs)
                .WithOptional(e => e.KHACHHANG)
                .HasForeignKey(e => e.MACN);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CALAMVIECs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.THUCUNGs)
                .WithMany(e => e.NHANVIENs)
                .Map(m => m.ToTable("PHUCVU").MapLeftKey("MANV").MapRightKey("MATC"));

            modelBuilder.Entity<THUCAN>()
                .Property(e => e.MATA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCUNG>()
                .Property(e => e.MATC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCUNG>()
                .Property(e => e.MACN)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
