using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class PhieuNhapDauSach
    {
        public int ID { get; set; }
        public int DauSachID { get; set; }
        [ForeignKey("DauSachID")]
        public virtual DauSach DauSach { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuongCuonSach { get; set; }
    }
}
