using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class NhanVien
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string MaNhanVien { get; set; }
        [Required]
        [StringLength(255)]
        public string Ten { get; set; }
        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(11)]
        public string DienThoai { get; set; }
        [Required]
        public byte TinhTrangID { get; set; }
        [ForeignKey("TinhTrangID")]
        public virtual TinhTrang TinhTrang { get; set; }
    }
}
