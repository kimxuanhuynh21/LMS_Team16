using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thu_Vien_MVC.Models
{
    public class ThongKeSachMuonViewModel
    {
        public ThongKeSachMuonViewModel() { }

        public DateTime? NgayMuon { get; set; }
        public int DocGiaID { get; set; }
        public string MaThe { get; set; }
        public string TenDocGia { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int PhieuMuonID { get; set; }
        public int CuonSachID { get; set; }
        public int TinhTrang_CT { get; set; }

    }
}