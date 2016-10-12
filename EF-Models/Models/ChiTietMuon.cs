using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class ChiTietMuon
    {
        public int ID { get; set; }
        [Required]
        public int PhieuMuonID { get; set; }
        [ForeignKey("PhieuMuonID")]
        public virtual PhieuMuon PhieuMuon { get; set; }
        public int CuonSachID { get; set; }
        [ForeignKey("CuonSachID")]
        public virtual CuonSach CuonSach { get; set; }
        public byte TinhTrangID { get; set; }
        [ForeignKey("TinhTrangID")]
        public virtual TinhTrang TinhTrang { get; set; }
    }
}
