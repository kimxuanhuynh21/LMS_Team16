using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models.Models;
using EF_Models.Handlers;

namespace EF_Models.ViewModels
{
    public class DocGiaViewModel
    {
        public DocGiaViewModel() { }

        public DocGiaViewModel( DocGia obj)
        {
            ID = obj.ID;
            MaThe = obj.MaThe;
            Ten = obj.Ten;
            DiaChi = obj.DiaChi;
            Email = obj.Email;
            DienThoai = obj.DienThoai;
            NgayCapThe = obj.NgayCapThe;
            NgayHetHan = obj.NgayHetHan;
            NamTotNghiep = obj.NamTotNghiep;
            LoaiID = obj.Loai;
            Loai = obj.Loai != null ? CommonHandler.GetEnumDescription((ConstantHandler.Loai_DocGia)LoaiID) : string.Empty;
            HinhAnh = obj.HinhAnh;
            SoSachConLai = obj.SoSachConLai;
            TinhTrangID = obj.TinhTrang;
            TinhTrang = obj.TinhTrang != null ? CommonHandler.GetEnumDescription((ConstantHandler.TinhTrang_DocGia)TinhTrangID) : string.Empty;
        }

        public int ID { get; set; }
        public string MaThe { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayCapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int NamTotNghiep { get; set; }
        public byte LoaiID { get; set; }
        public string Loai { get; set; }
        public string HinhAnh { get; set; }
        public int SoSachConLai { get; set; }
        public byte TinhTrangID { get; set; }
        public string TinhTrang { get; set; }
    }
}
