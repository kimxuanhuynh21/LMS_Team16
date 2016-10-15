namespace EF_Models.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class ThuVienDbContext : DbContext
    {
        public ThuVienDbContext()
            : base("name=ThuVienDbContext")
        {
        }

        //
        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<DauSach> DauSach { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<ChiTietMuon> ChiTietMuon { get; set; }
        public DbSet<ChiTietTra> ChiTietTra { get; set; }
        public DbSet<CuonSach> CuonSach { get; set; }
        public DbSet<DangKy> DangKy { get; set; }
        public DbSet<DocGia> DocGia { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public DbSet<PhieuMuon> PhieuMuon { get; set; }
        public DbSet<PhieuTra> PhieuTra { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            // Set the table name
            modelBuilder.Entity<TheLoai>().ToTable("TheLoai", "dbo");
            // Set the table name
            modelBuilder.Entity<DauSach>().ToTable("DauSach", "dbo");
            // Set the table name
            modelBuilder.Entity<TacGia>().ToTable("TacGia", "dbo");
            // Set the table name
            modelBuilder.Entity<CuonSach>().ToTable("CuonSach", "dbo");
            // Set the table name
            modelBuilder.Entity<ChiTietMuon>().ToTable("ChiTietMuon", "dbo");
            // Set the table name
            modelBuilder.Entity<ChiTietTra>().ToTable("ChiTietTra", "dbo");
            // Set the table name
            modelBuilder.Entity<DangKy>().ToTable("DangKy", "dbo");
            // Set the table name
            modelBuilder.Entity<DocGia>().ToTable("DocGia", "dbo");
            // Set the table name
            modelBuilder.Entity<NhanVien>().ToTable("NhanVien", "dbo");
            // Set the table name
            modelBuilder.Entity<NhaSanXuat>().ToTable("NhaSanXuat", "dbo");
            // Set the table name
            modelBuilder.Entity<PhieuMuon>().ToTable("PhieuMuon", "dbo");
            // Set the table name
            modelBuilder.Entity<PhieuTra>().ToTable("PhieuTra", "dbo");
            base.OnModelCreating(modelBuilder);

        }
    }
}
