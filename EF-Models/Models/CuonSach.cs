using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class CuonSach
    {
        public int ID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string MaVach { get; set; }
        [Required]
        public int DauSachID { get; set; }
        [ForeignKey("DauSachID")]
        public virtual DauSach DauSach { get; set; }
        [Required]
        public byte TinhTrangID { get; set; }
        [ForeignKey("TinhTrangID")]
        public virtual TinhTrang TinhTrang { get; set; }
    }
}
