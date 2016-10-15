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
                  new TheLoai { ID = 1, Ten = "Kinh dị" },
                  new TheLoai { ID = 2, Ten = "Tình cảm" },
                  new TheLoai { ID = 3, Ten = "Khoa học" }
            );

            context.NhaSanXuat.AddOrUpdate(
                 new NhaSanXuat { ID = 1, Ten = "Kinh Dị", DienThoai = "01212168031", DiaChi = "Phan Văn Khỏe" },
                 new NhaSanXuat { ID = 2, Ten = "Tình cảm", DienThoai = "01212168031", DiaChi = "Phan Văn Khỏe" },
                 new NhaSanXuat { ID = 3, Ten = "Khoa học", DienThoai = "01212168031", DiaChi = "Phan Văn Khỏe" },
                 new NhaSanXuat { ID = 4, Ten = "Tâm lý", DienThoai = "01212168031", DiaChi = "Phan Văn Khỏe" }
           );

            context.TacGia.AddOrUpdate(
               new TacGia { ID = 1, Ten = "Xuân" },
               new TacGia { ID = 2, Ten = "Bình" },
               new TacGia { ID = 3, Ten = "Tuấn" }
           );

            context.DauSach.AddOrUpdate(
                new DauSach { ID = 1, TheLoaiID = 1, TacGiaID = 1, Ten = "Em yêu", TomTat = "Buồn", TaiBan = 23, NhaSanXuatID = 1, SoLuongTong = 30, SoLuongTon = 30, TinhTrang = 0 }
                );
        }
    }
}
