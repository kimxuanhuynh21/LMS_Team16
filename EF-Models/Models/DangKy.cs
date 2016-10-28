using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class DangKy
    {
        public int ID { get; set; }
        [Required]
        [Index(IsUnique =true)]
        public int DocGiaID { get; set; }
        [ForeignKey("DocGiaID")]
        public virtual DocGia DocGia { get; set; }
        [Required]
        public int DauSachID { get; set; }
        [ForeignKey("DauSachID")]
        public virtual DauSach DauSach { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayDangKy { get; set; }
        [Required]
        [Range(0,1)]
        public byte TinhTrang { get; set; }
    }
}
