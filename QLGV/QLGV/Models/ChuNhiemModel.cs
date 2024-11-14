using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{ 
    public class ChuNhiemModel: BaseModel
    {
        public int ChuNhiemId { get; set; }
        public int GiaoVienId { get; set; }
        public string TenLop { get; set; }
        public string NamHoc { get; set; }
    }
}
