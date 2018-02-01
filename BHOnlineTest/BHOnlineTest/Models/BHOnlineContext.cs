namespace BHOnlineTest.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BHOnlineContext : DbContext
    {
        public BHOnlineContext()
            : base("name=BHOnlineContext")
        {
        }

        public virtual DbSet<bh_giamgia> bh_giamgia { get; set; }
        public virtual DbSet<bh_hoadon> bh_hoadon { get; set; }
        public virtual DbSet<bh_khachhang> bh_khachhang { get; set; }
        public virtual DbSet<bh_nhanvien> bh_nhanvien { get; set; }
        public virtual DbSet<bh_nhomsp> bh_nhomsp { get; set; }
        public virtual DbSet<bh_nsd> bh_nsd { get; set; }
        public virtual DbSet<bh_sanpham> bh_sanpham { get; set; }
        public virtual DbSet<bh_tomtatsp> bh_tomtatsp { get; set; }
        public virtual DbSet<bh_tt_xemay> bh_tt_xemay { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<bh_giamgia>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_giamgia>()
                .Property(e => e.Masp)
                .IsUnicode(false);

            modelBuilder.Entity<bh_giamgia>()
                .HasMany(e => e.bh_hoadon)
                .WithOptional(e => e.bh_giamgia)
                .HasForeignKey(e => e.Magiamgia);

            modelBuilder.Entity<bh_hoadon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<bh_hoadon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<bh_hoadon>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<bh_hoadon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<bh_hoadon>()
                .Property(e => e.Magiamgia)
                .IsUnicode(false);

            modelBuilder.Entity<bh_khachhang>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_khachhang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<bh_khachhang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<bh_khachhang>()
                .HasMany(e => e.bh_hoadon)
                .WithOptional(e => e.bh_khachhang)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<bh_nhanvien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nhomsp>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nhomsp>()
                .Property(e => e.Hinh)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nhomsp>()
                .HasMany(e => e.bh_sanpham)
                .WithOptional(e => e.bh_nhomsp)
                .HasForeignKey(e => e.Manhom);

            modelBuilder.Entity<bh_nsd>()
                .Property(e => e.Madn)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nsd>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nsd>()
                .Property(e => e.Quyen)
                .IsUnicode(false);

            modelBuilder.Entity<bh_nsd>()
                .Property(e => e.Manv)
                .IsUnicode(false);

            modelBuilder.Entity<bh_sanpham>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_sanpham>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<bh_sanpham>()
                .Property(e => e.Hinhanh)
                .IsUnicode(false);

            modelBuilder.Entity<bh_sanpham>()
                .Property(e => e.Manhom)
                .IsUnicode(false);

            modelBuilder.Entity<bh_sanpham>()
                .HasMany(e => e.bh_hoadon)
                .WithOptional(e => e.bh_sanpham)
                .HasForeignKey(e => e.MaSP);

            modelBuilder.Entity<bh_tomtatsp>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_tomtatsp>()
                .HasOptional(e => e.bh_sanpham)
                .WithRequired(e => e.bh_tomtatsp);

            modelBuilder.Entity<bh_tt_xemay>()
                .Property(e => e.Ma)
                .IsUnicode(false);

            modelBuilder.Entity<bh_tt_xemay>()
                .Property(e => e.BKS)
                .IsUnicode(false);

            modelBuilder.Entity<bh_tt_xemay>()
                .Property(e => e.SoKhung)
                .IsUnicode(false);

            modelBuilder.Entity<bh_tt_xemay>()
                .Property(e => e.SoMay)
                .IsUnicode(false);

            modelBuilder.Entity<bh_tt_xemay>()
                .HasOptional(e => e.bh_sanpham)
                .WithRequired(e => e.bh_tt_xemay);
        }
    }
}
