using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models.Models;

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
            TinhTrang = obj.TinhTrang;
        }

        public int ID { get; set; }
        public string MaVach { get; set; }
        public int DauSachID { get; set; }
        public string DauSach { get; set; }
        public byte TinhTrang { get; set; }
    }
}
