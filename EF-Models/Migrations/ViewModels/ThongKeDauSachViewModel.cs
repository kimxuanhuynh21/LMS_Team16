using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models.Models;

namespace EF_Models.ViewModels
{
    public class ThongKeDauSachViewModel
    {
        public ThongKeDauSachViewModel() { }

        public ThongKeDauSachViewModel(ThongKeDauSach obj) 
        {
            ID = obj.ID;
            DauSachID = obj.DauSachID;
            DauSach = obj.DauSach.Ten;
            Ngay = obj.Ngay;
            SoLuongHienTai = obj.SoLuongHienTai;
            SoLuongDaMuon = obj.DauSach.SoLuongTon - obj.SoLuongHienTai;
        }

        public int ID { get; set; }
        public int DauSachID { get; set; }
        public string DauSach { get; set; }
        public DateTime Ngay { get; set; }
        public int SoLuongHienTai { get; set; }
        public int SoLuongDaMuon { get; set; }
    }
}
