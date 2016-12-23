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
            DateTime dateValue = new DateTime();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.TheLoai.AddOrUpdate(
                  new TheLoai { ID = 1, MaTheLoai="VH", Ten = "Văn học" },
                  new TheLoai { ID = 2, MaTheLoai = "KT", Ten = "Kiến thức" },
                  new TheLoai { ID = 3, MaTheLoai = "KH", Ten = "Khoa học" },
                  new TheLoai { ID = 4, MaTheLoai = "TT", Ten = "Truyện tranh" }
            );

            context.NhaSanXuat.AddOrUpdate(
                 new NhaSanXuat { ID = 1, Ten = "Kim Đồng", DienThoai = "089439001 ", DiaChi = "55 Quang Trung, Hà Nội" },
                 new NhaSanXuat { ID = 2, Ten = "Lao động", DienThoai = "088515381 ", DiaChi = "175 Giảng Võ, Hà Nội" },
                 new NhaSanXuat { ID = 3, Ten = "Thanh Niên", DienThoai = "089434044", DiaChi = "62 Bà Triệu, Hà Nội" },
                 new NhaSanXuat { ID = 4, Ten = "Trẻ", DienThoai = "088316211 ", DiaChi = "161B Lý Chính Thắng, Q3, Thành phố Hồ Chí Minh" }
           );

            context.TacGia.AddOrUpdate(
               new TacGia { ID = 1, Ten = "Trần Tiến Luật" },
               new TacGia { ID = 2, Ten = "Cao Xuân Sơn" },
               new TacGia { ID = 3, Ten = "Nguyễn Thế Quang" },
               new TacGia { ID = 4, Ten = "Lê Quang Vịnh" }
           );

            context.DauSach.AddOrUpdate(
                new DauSach { ID = 1, TheLoaiID = 1, TacGiaID = 1, Ten = "Rượt đuổi", TomTat = "Đây là câu chuyện về ba người bạn: Raphael, Gardo và Chuột. Sống trong khu ổ chuột và kiếm sống bằng nghề bới rác, bất ngờ một ngày nọ, ba bạn nhỏ phát hiện ra một chiếc ví bị vứt bỏ trong đống rác… Trong ví, không chỉ có tiền bạc mà còn chứa cả một bí mật lớn lao và vô cùng nguy hiểm.", TaiBan = 1, NhaSanXuatID = 1, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 2, TheLoaiID = 2, TacGiaID = 2, Ten = "Hỏi lá, hỏi hoa", TomTat = "Mỗi bài thơ trong Hỏi lá, hỏi hoa là một giai điệu đầy cảm xúc về thế giới bao la của tình yêu thương con người, thiên nhiên, vạn vật.", TaiBan = 1, NhaSanXuatID = 2, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 3, TheLoaiID = 3, TacGiaID = 3, Ten = "Chị Sáu ở Côn Đảo", TomTat = "Truyện kể về chị Võ Thị Sáu, người con gái Đất Đỏ anh hùng.", TaiBan = 2, NhaSanXuatID = 3, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 2, TT_Xoa = 0 },
                new DauSach { ID = 4, TheLoaiID = 4, TacGiaID = 4, Ten = "Kính vạn hoa", TomTat = "Bộ truyện được yêu thích của các em nhỏ với nhiều đề tài: tình cảm gia đình, trường lớp, bạn bè...", TaiBan = 2, NhaSanXuatID = 4, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },

                new DauSach { ID = 5, TheLoaiID = 1, TacGiaID = 1, Ten = "Vòng quay sự sống - Cây ơi lớn mau", TomTat = "Cùng xem cách ươm một hạt đậu và quá trình sinh trưởng, phát triển của nó để thấy thiên nhiên thật diệu kì.", TaiBan = 1, NhaSanXuatID = 1, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 6, TheLoaiID = 2, TacGiaID = 2, Ten = "Việt Nam sử lược", TomTat = "Sử là sách không những là chỉ để ghi chép những công việc đã qua mà thôi, nhưng lại phải suy xét việc gốc ngọn, tìm tòi cái căn nguyên những công việc của người ta.", TaiBan = 2, NhaSanXuatID = 2, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 1, TT_Xoa = 0 },
                new DauSach { ID = 7, TheLoaiID = 3, TacGiaID = 3, Ten = "Lược sử thế giới bằng tranh - Đế quốc Mông Cổ", TomTat = "Đây là bộ sách lược sử thế giới bằng tranh gồm 11 tập kể về các thời kì lịch sử của thế giới từ xã hội nguyên thủy, xã hội phong kiến, các cuộc chiến tranh thế giới tới thời hiện đại.", TaiBan = 3, NhaSanXuatID = 3, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 2, TT_Xoa = 0 },
                new DauSach { ID = 8, TheLoaiID = 4, TacGiaID = 4, Ten = "Vòng quay sự sống - Cây ơi lớn mau", TomTat = "Cùng xem cách ươm một hạt đậu và quá trình sinh trưởng, phát triển của nó để thấy thiên nhiên thật diệu kì.", TaiBan = 1, NhaSanXuatID = 4, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },

                new DauSach { ID = 9, TheLoaiID = 1, TacGiaID = 1, Ten = "Truyện cổ tích Việt Nam dành cho bé hiếu học", TomTat = "Truyện cổ tích Việt Nam chứa đựng những ước mơ của cha ông và gói ghém nhiều bài học cho con cháu mai sau.", TaiBan = 1, NhaSanXuatID = 1, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 10, TheLoaiID = 2, TacGiaID = 2, Ten = "Tranh truyện lịch sử Việt Nam - Trần Nhân Tông", TomTat = "Trần Nhân Tông (1258 - 1308) được sử sách ngợi ca là một trong những vị vua anh minh nhất trong lịch sử.", TaiBan = 2, NhaSanXuatID = 2, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 11, TheLoaiID = 3, TacGiaID = 3, Ten = "Tranh truyện dân gian Việt Nam - Chử Đồng Tử và Tiên Dung", TomTat = "Bãi Tự Nhiên, đầm Nhất Dạ thuộc tỉnh Hưng Yên nước ta ngày nay là chứng tích nhắc nhớ về một truyền thuyết xa xưa, từ đời Hùng Vương thứ ba.", TaiBan = 3, NhaSanXuatID = 3, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 },
                new DauSach { ID = 12, TheLoaiID = 4, TacGiaID = 4, Ten = "Trí thông minh của bé - Mọt sách thông thái", TomTat = "Milo tự xem mình là biết tuốt nhờ mê đọc sách. Cậu có thể đọc bất cứ cuốn sách nào. Cậu đọc mọi lúc mọi nơi.", TaiBan = 4, NhaSanXuatID = 4, SoLuongTong = 10, SoLuongTon = 10, TinhTrang = 0, TT_Xoa = 0 }
           );

            context.CuonSach.AddOrUpdate(
                new CuonSach { ID = 1, MaVach = "VH1", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 2, MaVach = "VH2", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 3, MaVach = "VH3", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 4, MaVach = "VH4", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 5, MaVach = "VH5", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 6, MaVach = "VH6", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 7, MaVach = "VH7", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 8, MaVach = "VH8", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 9, MaVach = "VH9", DauSachID = 1, TinhTrang = 2 },

                new CuonSach { ID = 10, MaVach = "VH10", DauSachID = 1, TinhTrang = 2 },
                new CuonSach { ID = 11, MaVach = "VH11", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 12, MaVach = "VH12", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 13, MaVach = "VH13", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 14, MaVach = "VH14", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 15, MaVach = "VH15", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 16, MaVach = "VH16", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 17, MaVach = "VH17", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 18, MaVach = "VH18", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 19, MaVach = "VH19", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 20, MaVach = "VH20", DauSachID = 2, TinhTrang = 2 }
           );

            context.DocGia.AddOrUpdate(
                new DocGia { ID = 1, MaThe = "DG1", Ten = "Huỳnh Kim Xuân", DiaChi = "210 Phan Văn Khỏe", Email ="kimxuanhuynh21@gmail.com", DienThoai = "01212186032", NgayCapThe = DateTime.ParseExact("21/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("21/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 2018, Loai = 0, SoSachConLai = 5, TinhTrang = 0,HinhAnh = @"/EF-Models/Images/2.jpg" },
                new DocGia { ID = 2, MaThe = "DG2", Ten = "Ngô Văn Lợi", DiaChi = "12 An Dương Vương", Email = "vanloi@gmail.com", DienThoai = "01212134567", NgayCapThe = DateTime.ParseExact("20/10/2016","dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("20/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 1998, Loai = 1, SoSachConLai = 5, TinhTrang = 0, HinhAnh = @"/EF-Models/Images/Back-Swept-Quiff-haircuts-men.jpg" }
           );

            context.NhanVien.AddOrUpdate(
                new NhanVien { ID = 1, MaNhanVien = "NV1", Ten = "Nguyễn Văn A", DiaChi = "13 Hậu Giang", Email = "vana@gmail.com", DienThoai = "0909342967", TinhTrang = 1}
           );

            context.DangKy.AddOrUpdate(
                new DangKy { ID = 1, DocGiaID = 1, DauSachID = 1, NgayDangKy = DateTime.ParseExact("21/10/2016","dd/MM/yyyy",CultureInfo.InvariantCulture),TinhTrang = 0}
           );

           // context.PhieuMuon.AddOrUpdate(
           //     new PhieuMuon { ID = 1, MaPhieuMuon = "PM1", NgayMuon = DateTime.ParseExact("20/10/2016","dd/MM/yyyy",CultureInfo.InvariantCulture), DocGiaID = 1, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("19/11/2016","dd/MM/yyyy",CultureInfo.InvariantCulture),TongSoLuongMuon = 2, TinhTrang = 0 },
           //     new PhieuMuon { ID = 2, MaPhieuMuon = "PM2", NgayMuon = DateTime.ParseExact("22/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 1, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("21/11/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), TongSoLuongMuon = 1, TinhTrang = 0 },
           //     new PhieuMuon { ID = 3, MaPhieuMuon = "PM3", NgayMuon = DateTime.ParseExact("24/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 2, NhanVienID = 1, NgayHetHan = DateTime.ParseExact("23/11/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), TongSoLuongMuon = 2, TinhTrang = 0 }
           //);

           // context.ChiTietMuon.AddOrUpdate(
           //     new ChiTietMuon { ID = 1, PhieuMuonID = 1, CuonSachID = 1, TinhTrang = 0 },
           //     new ChiTietMuon { ID = 2, PhieuMuonID = 1, CuonSachID = 2, TinhTrang = 0 },
           //     new ChiTietMuon { ID = 3, PhieuMuonID = 2, CuonSachID = 3, TinhTrang = 0 },
           //     new ChiTietMuon { ID = 4, PhieuMuonID = 3, CuonSachID = 3, TinhTrang = 0 },
           //     new ChiTietMuon { ID = 5, PhieuMuonID = 3, CuonSachID = 3, TinhTrang = 0 }
           //);

           // context.PhieuTra.AddOrUpdate(
           //     new PhieuTra { ID = 1, MaPhieuTra = "PT1", NgayTra = DateTime.ParseExact("22/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), DocGiaID = 1}
           //);

           // context.ChiTietTra.AddOrUpdate(
           //     new ChiTietTra { ID = 1, PhieuTraID = 1, CuonSachID = 1}
           //);
        }
    }
}
