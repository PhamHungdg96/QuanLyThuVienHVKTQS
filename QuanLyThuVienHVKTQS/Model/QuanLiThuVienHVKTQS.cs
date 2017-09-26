namespace QuanLyThuVienHVKTQS.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLiThuVienHVKTQS : DbContext
    {
        public QuanLiThuVienHVKTQS()
            : base("name=QuanLiThuVienHVKTQS")
        {
        }

        public virtual DbSet<docgia> docgias { get; set; }
        public virtual DbSet<muonsach> muonsaches { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<nhaxuatban> nhaxuatbans { get; set; }
        public virtual DbSet<sach> saches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<docgia>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<docgia>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<docgia>()
                .Property(e => e.socmtnd)
                .IsUnicode(false);

            modelBuilder.Entity<docgia>()
                .Property(e => e.anhthe)
                .IsUnicode(false);

            modelBuilder.Entity<docgia>()
                .HasMany(e => e.muonsaches)
                .WithRequired(e => e.docgia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<muonsach>()
                .Property(e => e.tennv)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.tendangnhap)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.socmtnd)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.anh)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.quyenhan)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<nhanvien>()
                .HasMany(e => e.muonsaches)
                .WithRequired(e => e.nhanvien)
                .HasForeignKey(e => e.tennv)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nhaxuatban>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.giatien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<sach>()
                .HasMany(e => e.muonsaches)
                .WithRequired(e => e.sach)
                .WillCascadeOnDelete(false);
        }
    }
}
