using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class NhaSanXuat
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Ten{ get; set; }
        [Required]
        [StringLength(11)]
        public string DienThoai { get; set; }
        [Required]
        [StringLength(255)]
        public string DiaChi { get; set; }
    }
}
