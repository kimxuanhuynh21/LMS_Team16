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
        public CuonSach() { }
        public CuonSach(CuonSach obj) 
        {
            ID = obj.ID;
            MaVach = obj.MaVach;
            DauSachID = obj.DauSachID;
            DauSach = obj.DauSach;
            TinhTrang = obj.TinhTrang;
        }
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
        [Range(0,3)]
        public byte TinhTrang { get; set; }
    }
}
