using QLGV.Models;
using QLGV.Views.BoMon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.BoMon
{
    public class BoMonAddDto
    {
        public string TenBoMon { get; set; }

        public static BoMonAddDto FromView(IBoMonAdd view)
        {
            return new BoMonAddDto()
            {
                TenBoMon = view.TenBoMon.Trim(),
            };
        }

        public  BoMonModel ToModel()
        {
            return new BoMonModel()
            {
                TenBoMon = TenBoMon,
            };
        }
    }
}
