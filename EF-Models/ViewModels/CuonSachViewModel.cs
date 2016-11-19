using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models.Models;
using EF_Models.Handlers;

namespace EF_Models.ViewModels
{
    public class CuonSachViewModel
    {
        public CuonSachViewModel() { }

        public CuonSachViewModel(CuonSach obj)
        {
            ID = obj.ID;
            MaVach = obj.MaVach;
            DauSachID = obj.DauSachID;
            DauSach = obj.DauSach.Ten;
            TinhTrangID = obj.TinhTrang;
            TinhTrang = obj.TinhTrang != null ? CommonHandler.GetEnumDescription((ConstantHandler.TinhTrang_CuonSach)TinhTrangID) : string.Empty;
        }

        public int ID { get; set; }
        public string MaVach { get; set; }
        public int DauSachID { get; set; }
        public string DauSach { get; set; }
        public byte TinhTrangID { get; set; }
        public string TinhTrang { get; set; }
    }
}
