using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models.Models;
using EF_Models.Handlers;

namespace EF_Models.ViewModels
{
    public class DauSachViewModel
    {
        public DauSachViewModel() { }

        public DauSachViewModel(DauSach obj)
        {
            ID = obj.ID;
            Ten = obj.Ten;
            TheLoaiID = obj.TheLoaiID;
            TheLoai = obj.TheLoai.Ten;
            TacGiaID = obj.TacGiaID;
            TacGia = obj.TacGia.Ten;
            TomTat = obj.TomTat;
            TaiBan = obj.TaiBan;
            NhaSanXuatID = obj.NhaSanXuatID;
            NhaSanXuat = obj.NhaSanXuat.Ten;
            SoLuongTong = obj.SoLuongTong;
            SoLuongTon = obj.SoLuongTon;
            TinhTrangID = obj.TinhTrang;
            TinhTrang = obj.TinhTrang != null ? CommonHandler.GetEnumDescription((ConstantHandler.TinhTrang_DauSach)TinhTrangID) : string.Empty;
        }

        public int ID { get; set; }
        public string Ten { get; set; }
        public int TheLoaiID { get; set; }
        public string TheLoai { get; set; }
        public int TacGiaID { get; set; }
        public string TacGia { get; set; }
        public string TomTat { get; set; }
        public int TaiBan { get; set; }
        public int NhaSanXuatID { get; set; }
        public string NhaSanXuat { get; set; }
        public int SoLuongTong { get; set; }
        public int SoLuongTon { get; set; }
        public byte TinhTrangID { get; set; }
        public string TinhTrang { get; set; }
    }
}
