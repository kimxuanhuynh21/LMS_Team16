using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class DocGia
    {
        public int ID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string MaThe { get; set; }
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
        [DataType(DataType.Date)]
        public DateTime NgayCapThe { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayHetHan { get; set; }
        public int NamTotNghiep { get; set; }
        [Required]
        [Range(0,1)]
        public byte Loai { get; set; }
        public int SoSachConLai { get; set; }
        [Required]
        [Range(0,2)]
        public byte TinhTrang { get; set; }
    }
}
