namespace EF_Models.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Models.Models.ThuVienDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_Models.Models.ThuVienDbContext context)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime dateValue;
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.TheLoai.AddOrUpdate(
                  new TheLoai { ID = 1, MaTheLoai="VH", Ten = "Văn học" },
                  new TheLoai { ID = 2, MaTheLoai = "KT", Ten = "Kiến thức" },
                  new TheLoai { ID = 3, MaTheLoai = "KH", Ten = "Khoa học" },
                  new TheLoai { ID = 4, MaTheLoai = "TT", Ten = "Truyện tranh" },
                  new TheLoai { ID = 5, MaTheLoai = "MG", Ten = "Manga" }
            );

            context.NhaSanXuat.AddOrUpdate(
                 new NhaSanXuat { ID = 1, Ten = "Kim Đồng", DienThoai = "089439001 ", DiaChi = "55 Quang Trung, Hà Nội" },
                 new NhaSanXuat { ID = 2, Ten = "Lao động", DienThoai = "088515381 ", DiaChi = "175 Giảng Võ, Hà Nội" },
                 new NhaSanXuat { ID = 3, Ten = "Thanh Niên", DienThoai = "089434044", DiaChi = "62 Bà Triệu, Hà Nội" },
                 new NhaSanXuat { ID = 4, Ten = "Trẻ", DienThoai = "088316211 ", DiaChi = "161B Lý Chính Thắng, Q3, Thành phố Hồ Chí Minh" },
                 new NhaSanXuat { ID = 5, Ten = "Văn học", DienThoai = "088294782 ", DiaChi = "18 Nguyễn Trường Tộ, Hà Nội" }
           );

            context.TacGia.AddOrUpdate(
               new TacGia { ID = 1, Ten = "Andy Mulligan" },
               new TacGia { ID = 2, Ten = "Cao Xuân Sơn" },
               new TacGia { ID = 3, Ten = "Lê Quang Vịnh" }
           );

            context.DauSach.AddOrUpdate(
                new DauSach { ID = 1, TheLoaiID = 1, TacGiaID = 1, Ten = "Rượt đuổi", TomTat = "Đây là câu chuyện về ba người bạn: Raphael, Gardo và Chuột. Sống trong khu ổ chuột và kiếm sống bằng nghề bới rác, bất ngờ một ngày nọ, ba bạn nhỏ phát hiện ra một chiếc ví bị vứt bỏ trong đống rác… Trong ví, không chỉ có tiền bạc mà còn chứa cả một bí mật lớn lao và vô cùng nguy hiểm.", TaiBan = 1, NhaSanXuatID = 1, SoLuongTong = 20, SoLuongTon = 20, TinhTrang = 0 },
                new DauSach { ID = 2, TheLoaiID = 1, TacGiaID = 2, Ten = "Hỏi lá, hỏi hoa", TomTat = "Mỗi bài thơ trong Hỏi lá, hỏi hoa là một giai điệu đầy cảm xúc về thế giới bao la của tình yêu thương con người, thiên nhiên, vạn vật.", TaiBan = 1, NhaSanXuatID = 2, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 1 },
                new DauSach { ID = 3, TheLoaiID = 1, TacGiaID = 3, Ten = "Chị Sáu ở Côn Đảo", TomTat = "Truyện kể về chị Võ Thị Sáu, người con gái Đất Đỏ anh hùng.", TaiBan = 1, NhaSanXuatID = 3, SoLuongTong = 30, SoLuongTon = 30, TinhTrang = 2 }
           );

            context.CuonSach.AddOrUpdate(
                new CuonSach { ID = 1, MaVach = "VH1", DauSachID = 1, TinhTrang = 2},
                new CuonSach { ID = 2, MaVach = "VH2", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 3, MaVach = "VH3", DauSachID = 3, TinhTrang = 1 }
           );

            context.DocGia.AddOrUpdate(
                new DocGia { ID = 1, MaThe = "DG1", Ten = "Huỳnh Kim Xuân", DiaChi = "210 Phan Văn Khỏe", Email ="kimxuanhuynh21@gmail.com", DienThoai = "01212186032", NgayCapThe = DateTime.ParseExact("21/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("21/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 2018, Loai = 0, SoSachConLai = 2, TinhTrang = 0},
                new DocGia { ID = 2, MaThe = "DG2", Ten = "Ngô Văn Lợi", DiaChi = "12 An Dương Vương", Email = "vanloi@gmail.com", DienThoai = "01212134567", NgayCapThe = DateTime.ParseExact("20/10/2016","dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("20/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 1998, Loai = 1, SoSachConLai = 2, TinhTrang = 0 }
           );

            context.NhanVien.AddOrUpdate(
                new NhanVien { ID = 1, MaNhanVien = "NV1", Ten = "Nguyễn Văn A", DiaChi = "13 Hậu Giang", Email = "vana@gmail.com", DienThoai = "0909342967", TinhTrang = 1}
           );

            context.DangKy.AddOrUpdate(
                new DangKy { ID = 1, DocGiaID = 1, DauSachID = 1, NgayDangKy = DateTime.ParseExact("21/10/2016","dd/MM/yyyy",CultureInfo.InvariantCulture),TinhTrang = 0}
           );

            context.PhieuMuon.AddOrUpdate(
                new PhieuMuon { ID = 1, MaPhieuMuon = "PM1", NgayMuon = DateTime.ParseExact("20/10/2016","dd/MM/yyyy",CultureInfo.InvariantCulture), DocGiaID = 1, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("19/11/2016","dd/MM/yyyy",CultureInfo.InvariantCulture),TongSoLuongMuon = 2, TinhTrang = 0 },
                new PhieuMuon { ID = 2, MaPhieuMuon = "PM2", NgayMuon = DateTime.ParseExact("22/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 1, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("21/11/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), TongSoLuongMuon = 1, TinhTrang = 0 },
                new PhieuMuon { ID = 3, MaPhieuMuon = "PM3", NgayMuon = DateTime.ParseExact("24/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 2, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("23/11/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), TongSoLuongMuon = 2, TinhTrang = 0 }
           );

            context.ChiTietMuon.AddOrUpdate(
                new ChiTietMuon { ID = 1, PhieuMuonID = 1, CuonSachID = 1, TinhTrang = 0 },
                new ChiTietMuon { ID = 2, PhieuMuonID = 1, CuonSachID = 2, TinhTrang = 0 },
                new ChiTietMuon { ID = 3, PhieuMuonID = 1, CuonSachID = 2, TinhTrang = 0 },
                new ChiTietMuon { ID = 4, PhieuMuonID = 2, CuonSachID = 3, TinhTrang = 0 }
           );

            context.PhieuTra.AddOrUpdate(
                new PhieuTra { ID = 1, MaPhieuTra = "PT1", PhieuMuonID = 1, NgayTra = DateTime.ParseExact("22/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 1}
           );

            context.ChiTietTra.AddOrUpdate(
                new ChiTietTra { ID = 1, PhieuTraID = 1, CuonSachID = 1}
           );
        }
    }
}
