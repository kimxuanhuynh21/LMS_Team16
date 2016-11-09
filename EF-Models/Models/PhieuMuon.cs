using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class PhieuMuon
    {
        public PhieuMuon()
        {
            this.dsChiTietMuon = new List<ChiTietMuon>();
        }
        public int ID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string MaPhieuMuon { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayMuon { get; set; }
        [Required]
        public int DocGiaID { get; set; }
        [ForeignKey("DocGiaID")]
        public virtual DocGia DocGia { get; set; }
        [Required]
        public int NhanVienID { get; set; }
        [ForeignKey("NhanVienID")]
        public virtual NhanVien NhanVien { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime NgayHetHan { get; set; }
        public int TongSoLuongMuon { get; set; }
        [Required]
        [Range(0,1)]
        public byte TinhTrang { get; set; }
        public virtual ICollection<ChiTietMuon> dsChiTietMuon { get; set; }
        
    }
}
