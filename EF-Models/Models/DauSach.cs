using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class DauSach
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Ten { get; set; }
        [Required]
        public int TheLoaiID { get; set; }
        [ForeignKey("TheLoaiID")]
        public virtual TheLoai TheLoai { get; set; }
        [Required]
        public int TacGiaID { get; set; }
        [ForeignKey("TacGiaID")]
        public virtual TacGia TacGia { get; set; }
        [StringLength(2000)]
        public string TomTat { get; set; }
        [Required]
        [Range(1, 50)]
        public int TaiBan { get; set; }
        [Required]
        public int NhaSanXuatID { get; set; }
        [ForeignKey("NhaSanXuatID")]
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        [Required]
        public int SoLuongTong { get; set; }
        public int SoLuongTon { get; set; }
        [Required]
        public byte TinhTrangID { get; set; }
        [ForeignKey("TinhTrangID")]
        public virtual TinhTrang TinhTrang { get; set; } 
    }
}