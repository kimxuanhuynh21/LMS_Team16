using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class TacGia
    {
        public TacGia() { }
        public TacGia(TacGia obj)
        {
            ID = obj.ID;
            Ten = obj.Ten;
        }
        public int ID{ get; set; }
        [Required]
        [StringLength(255)]
        public string Ten { get; set; }
    }
}
