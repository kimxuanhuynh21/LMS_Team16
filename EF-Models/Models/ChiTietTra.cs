using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class ChiTietTra
    {
        public int ID { get; set; }
        [Required]
        public int PhieuTraID { get; set; }
        [ForeignKey("PhieuTraID")]
        public virtual PhieuTra PhieuTra { get; set; }
        public int CuonSachID { get; set; }
        [ForeignKey("CuonSachID")]
        public virtual CuonSach CuonSach { get; set; }
    }
}
