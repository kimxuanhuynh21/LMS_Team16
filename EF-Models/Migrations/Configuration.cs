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
                new CuonSach { ID = 7, MaVach = "VH7", DauSachID = 1, TinhTrang = 0 },
                new CuonSach { ID = 8, MaVach = "VH8", DauSachID = 1, TinhTrang = 0 },
                new CuonSach { ID = 9, MaVach = "VH9", DauSachID = 1, TinhTrang = 3 },
                new CuonSach { ID = 10, MaVach = "VH10", DauSachID = 1, TinhTrang = 3 },

                new CuonSach { ID = 11, MaVach = "VH11", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 12, MaVach = "VH12", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 13, MaVach = "VH13", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 14, MaVach = "VH14", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 15, MaVach = "VH15", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 16, MaVach = "VH16", DauSachID = 2, TinhTrang = 2 },
                new CuonSach { ID = 17, MaVach = "VH17", DauSachID = 2, TinhTrang = 0 },
                new CuonSach { ID = 18, MaVach = "VH18", DauSachID = 2, TinhTrang = 0 },
                new CuonSach { ID = 19, MaVach = "VH19", DauSachID = 2, TinhTrang = 3 },
                new CuonSach { ID = 20, MaVach = "VH20", DauSachID = 2, TinhTrang = 3 },

                new CuonSach { ID = 21, MaVach = "VH21", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 22, MaVach = "VH22", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 23, MaVach = "VH23", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 24, MaVach = "VH24", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 25, MaVach = "VH25", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 26, MaVach = "VH26", DauSachID = 3, TinhTrang = 2 },
                new CuonSach { ID = 27, MaVach = "VH27", DauSachID = 3, TinhTrang = 0 },
                new CuonSach { ID = 28, MaVach = "VH28", DauSachID = 3, TinhTrang = 0 },
                new CuonSach { ID = 29, MaVach = "VH29", DauSachID = 3, TinhTrang = 3 },
                new CuonSach { ID = 30, MaVach = "VH30", DauSachID = 3, TinhTrang = 3 },

                new CuonSach { ID = 31, MaVach = "VH31", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 32, MaVach = "VH32", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 33, MaVach = "VH33", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 34, MaVach = "VH34", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 35, MaVach = "VH35", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 36, MaVach = "VH36", DauSachID = 4, TinhTrang = 2 },
                new CuonSach { ID = 37, MaVach = "VH37", DauSachID = 4, TinhTrang = 0 },
                new CuonSach { ID = 38, MaVach = "VH38", DauSachID = 4, TinhTrang = 0 },
                new CuonSach { ID = 39, MaVach = "VH39", DauSachID = 4, TinhTrang = 3 },
                new CuonSach { ID = 40, MaVach = "VH40", DauSachID = 4, TinhTrang = 3 },

                new CuonSach { ID = 41, MaVach = "VH41", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 42, MaVach = "VH42", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 43, MaVach = "VH43", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 44, MaVach = "VH44", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 45, MaVach = "VH45", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 46, MaVach = "VH46", DauSachID = 5, TinhTrang = 2 },
                new CuonSach { ID = 47, MaVach = "VH47", DauSachID = 5, TinhTrang = 0 },
                new CuonSach { ID = 48, MaVach = "VH48", DauSachID = 5, TinhTrang = 0 },
                new CuonSach { ID = 49, MaVach = "VH49", DauSachID = 5, TinhTrang = 3 },
                new CuonSach { ID = 50, MaVach = "VH50", DauSachID = 5, TinhTrang = 3 },

                new CuonSach { ID = 51, MaVach = "VH51", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 52, MaVach = "VH52", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 53, MaVach = "VH53", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 54, MaVach = "VH54", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 55, MaVach = "VH55", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 56, MaVach = "VH56", DauSachID = 6, TinhTrang = 2 },
                new CuonSach { ID = 57, MaVach = "VH57", DauSachID = 6, TinhTrang = 0 },
                new CuonSach { ID = 58, MaVach = "VH58", DauSachID = 6, TinhTrang = 0 },
                new CuonSach { ID = 59, MaVach = "VH59", DauSachID = 6, TinhTrang = 3 },
                new CuonSach { ID = 60, MaVach = "VH60", DauSachID = 6, TinhTrang = 3 },

                new CuonSach { ID = 60, MaVach = "VH60", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 61, MaVach = "VH61", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 62, MaVach = "VH62", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 63, MaVach = "VH63", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 64, MaVach = "VH64", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 65, MaVach = "VH65", DauSachID = 7, TinhTrang = 2 },
                new CuonSach { ID = 66, MaVach = "VH66", DauSachID = 7, TinhTrang = 0 },
                new CuonSach { ID = 67, MaVach = "VH67", DauSachID = 7, TinhTrang = 0 },
                new CuonSach { ID = 68, MaVach = "VH68", DauSachID = 7, TinhTrang = 3 },
                new CuonSach { ID = 70, MaVach = "VH70", DauSachID = 7, TinhTrang = 3 },

                new CuonSach { ID = 71, MaVach = "VH71", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 72, MaVach = "VH72", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 73, MaVach = "VH73", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 74, MaVach = "VH74", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 75, MaVach = "VH75", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 76, MaVach = "VH76", DauSachID = 8, TinhTrang = 2 },
                new CuonSach { ID = 77, MaVach = "VH77", DauSachID = 8, TinhTrang = 0 },
                new CuonSach { ID = 78, MaVach = "VH78", DauSachID = 8, TinhTrang = 0 },
                new CuonSach { ID = 79, MaVach = "VH79", DauSachID = 8, TinhTrang = 3 },
                new CuonSach { ID = 80, MaVach = "VH80", DauSachID = 8, TinhTrang = 3 },

                new CuonSach { ID = 81, MaVach = "VH81", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 82, MaVach = "VH82", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 83, MaVach = "VH83", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 84, MaVach = "VH84", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 85, MaVach = "VH85", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 86, MaVach = "VH86", DauSachID = 9, TinhTrang = 2 },
                new CuonSach { ID = 87, MaVach = "VH87", DauSachID = 9, TinhTrang = 0 },
                new CuonSach { ID = 88, MaVach = "VH88", DauSachID = 9, TinhTrang = 0 },
                new CuonSach { ID = 89, MaVach = "VH89", DauSachID = 9, TinhTrang = 3 },
                new CuonSach { ID = 90, MaVach = "VH90", DauSachID = 9, TinhTrang = 3 },

                new CuonSach { ID = 91, MaVach = "VH91", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 92, MaVach = "VH92", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 93, MaVach = "VH93", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 94, MaVach = "VH94", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 95, MaVach = "VH95", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 96, MaVach = "VH96", DauSachID = 10, TinhTrang = 2 },
                new CuonSach { ID = 97, MaVach = "VH97", DauSachID = 10, TinhTrang = 0 },
                new CuonSach { ID = 98, MaVach = "VH98", DauSachID = 10, TinhTrang = 0 },
                new CuonSach { ID = 99, MaVach = "VH99", DauSachID = 10, TinhTrang = 3 },
                new CuonSach { ID = 100, MaVach = "VH100", DauSachID = 10, TinhTrang = 3 },

                new CuonSach { ID = 101, MaVach = "VH101", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 102, MaVach = "VH102", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 103, MaVach = "VH103", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 104, MaVach = "VH104", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 105, MaVach = "VH105", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 106, MaVach = "VH106", DauSachID = 11, TinhTrang = 2 },
                new CuonSach { ID = 107, MaVach = "VH107", DauSachID = 11, TinhTrang = 0 },
                new CuonSach { ID = 108, MaVach = "VH108", DauSachID = 11, TinhTrang = 0 },
                new CuonSach { ID = 109, MaVach = "VH109", DauSachID = 11, TinhTrang = 3 },
                new CuonSach { ID = 110, MaVach = "VH110", DauSachID = 11, TinhTrang = 3 },

                new CuonSach { ID = 111, MaVach = "VH111", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 112, MaVach = "VH112", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 113, MaVach = "VH113", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 114, MaVach = "VH114", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 115, MaVach = "VH115", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 116, MaVach = "VH116", DauSachID = 12, TinhTrang = 2 },
                new CuonSach { ID = 117, MaVach = "VH117", DauSachID = 12, TinhTrang = 0 },
                new CuonSach { ID = 118, MaVach = "VH118", DauSachID = 12, TinhTrang = 0 },
                new CuonSach { ID = 119, MaVach = "VH119", DauSachID = 12, TinhTrang = 3 },
                new CuonSach { ID = 120, MaVach = "VH120", DauSachID = 12, TinhTrang = 3 }
           );

            context.DocGia.AddOrUpdate(
                new DocGia { ID = 1, MaThe = "DG1", Ten = "Cao San San", DiaChi = "210 Phan Văn Khỏe", Email ="sansan123@gmail.com", DienThoai = "01212186032", NgayCapThe = DateTime.ParseExact("21/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("21/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 2018, Loai = 1, SoSachConLai = 4, TinhTrang = 0,HinhAnh = @"/EF-Models/Images/2.jpg" },
                new DocGia { ID = 2, MaThe = "DG2", Ten = "Ngô Văn Lợi", DiaChi = "12 An Dương Vương", Email = "vanloi@gmail.com", DienThoai = "01212134567", NgayCapThe = DateTime.ParseExact("20/10/2016","dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("20/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 1998, Loai = 0, SoSachConLai = 5, TinhTrang = 0, HinhAnh = @"/EF-Models/Images/Back-Swept-Quiff-haircuts-men.jpg" },
                new DocGia { ID = 3, MaThe = "DG3", Ten = "Lưu Hoài Anh", DiaChi = "2 Hậu Giang", Email = "hoaianh@gmail.com", DienThoai = "01212112345", NgayCapThe = DateTime.ParseExact("01/08/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("01/08/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 2019, Loai = 1, SoSachConLai = 4, TinhTrang = 0, HinhAnh = @"/EF-Models/Images/2.jpg" },
                new DocGia { ID = 4, MaThe = "DG4", Ten = "Lý Trân Châu", DiaChi = "18 Kinh Dương Vương", Email = "tranchau@gmail.com", DienThoai = "01213312453", NgayCapThe = DateTime.ParseExact("13/09/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("13/09/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 1999, Loai = 0, SoSachConLai = 5, TinhTrang = 0, HinhAnh = @"/EF-Models/Images/2.jpg" },
                new DocGia { ID = 5, MaThe = "DG5", Ten = "Thái Lan Lan", DiaChi = "89 Hùng Vương", Email = "lanlan@gmail.com", DienThoai = "01212184444", NgayCapThe = DateTime.ParseExact("21/10/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("21/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 2018, Loai = 1, SoSachConLai = 4, TinhTrang = 1, HinhAnh = @"/EF-Models/Images/2.jpg" },
                new DocGia { ID = 6, MaThe = "DG6", Ten = "Tô Trinh Trinh", DiaChi = "11 Bình Tân", Email = "trinhtrinh123@gmail.com", DienThoai = "09093312453", NgayCapThe = DateTime.ParseExact("14/09/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture), NgayHetHan = DateTime.ParseExact("14/09/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture), NamTotNghiep = 1997, Loai = 0, SoSachConLai = 5, TinhTrang = 2, HinhAnh = @"/EF-Models/Images/2.jpg" }
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
