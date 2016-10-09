using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class DauSach
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public int TheLoaiId { get; set; }
        [ForeignKey("TheLoaiId")]
        public virtual TheLoai TheLoai { get; set; }
    }
}