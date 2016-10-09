namespace EF_Models.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ThuVienDbContext : DbContext
    {
        public ThuVienDbContext()
            : base("name=ThuVienDbContext")
        {
        }

        public DbSet<TheLoai> TheLoai { get; set; }
        public DbSet<DauSach> DauSach { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Set the table name
            modelBuilder.Entity<TheLoai>().ToTable("TheLoai", "dbo");
            // Set the table name
            modelBuilder.Entity<DauSach>().ToTable("DauSach", "dbo");
            base.OnModelCreating(modelBuilder);

        }
    }
}
