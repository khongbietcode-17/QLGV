using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    public class BangLuongModel: BaseModel
    {
        public int GiaoVienId { get; set; }
        public decimal HeSoLuong { get; set; }
        public decimal HeSoPhuCap { get; set; }
        public int Luong { get; set; }
        public GiaoVienModel GiaoVien { get; set; } 
    }
}
