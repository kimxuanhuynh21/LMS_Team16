namespace EF_Models.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Models.Models.ThuVienDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_Models.Models.ThuVienDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.TheLoai.AddOrUpdate(
              p => p.Ten,
              new TheLoai { Ten = "Kinh dị" },
              new TheLoai { Ten = "Tình cảm" },
              new TheLoai { Ten = "Khoa học" }
            );
            //
        }
    }
}
