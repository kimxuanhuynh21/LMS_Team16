using System;
using System.ComponentModel;

namespace EF_Models.Handlers
{
    public class ConstantHandler
    {
        public enum TinhTrang_DauSach
        {
            [Description("Cho Muon Ve Nha")]
            MuonVeNha = 0,
            [Description("Muon Doc Tai Cho")]
            DocTaiCho = 1,
            [Description("Dang Ki Photo")]
            DangKiPhoto = 2,
        }
    }
}
