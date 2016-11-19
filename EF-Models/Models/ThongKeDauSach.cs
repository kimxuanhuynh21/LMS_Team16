using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
   public class ThongKeDauSach
    {
        public int ID { get; set; }
        public int DauSachID { get; set; }
        [ForeignKey("DauSachID")]
        public virtual DauSach DauSach { get; set; }
        public DateTime Ngay { get; set; }
        public int SoLuongHienTai { get; set; }
    }
}
