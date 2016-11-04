using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class TheLoai
    {
        public TheLoai() { }
        public TheLoai(TheLoai obj) {

            ID = obj.ID;
            Ten = obj.Ten;
        }
        public int ID { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(100)]
        public string MaTheLoai { get; set; }
        [Required]
        [StringLength(255)]
        public string Ten { get; set; }
    }
}