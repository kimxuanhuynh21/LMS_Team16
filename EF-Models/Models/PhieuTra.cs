using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class PhieuTra
    {
        public int ID { get; set; }
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string MaPhieuTra { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgayTra { get; set; }
        [Required]
        public int DocGiaID { get; set; }
        [ForeignKey("DocGiaID")]
        public virtual DocGia DocGia { get; set; }
    }
}
