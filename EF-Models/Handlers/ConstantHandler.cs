using System;
using System.ComponentModel;

namespace EF_Models.Handlers
{
    public class ConstantHandler
    {
        public enum TinhTrang_DauSach
        {
            [Description("Mượn về nhà")]
            MuonVeNha = 0,
            [Description("Đọc tại chổ")]
            DocTaiCho = 1,
            [Description("Đăng kí Photo")]
            DangKiPhoto = 2,
        }

        public enum TinhTrang_CuonSach
        {
            [Description("Sách đã thanh lý ")]
            SachThanhLy = 0,
            [Description("Sách đã được mượn")]
            SachDaMuon = 1,
            [Description("Sách còn trong kho")]
            SachTrongKho = 2,
            [Description("Sách đang chờ bảo dưỡng")]
            SachBaoDuong = 3,
        }
    }
}
