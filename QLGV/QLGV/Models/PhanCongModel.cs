using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace QLGV.Models
{
    public class PhanCongModel: BaseModel
    {
        public int GiaoVienId { get; set; }
        public int ChucVuId { get; set; }
    }
}
