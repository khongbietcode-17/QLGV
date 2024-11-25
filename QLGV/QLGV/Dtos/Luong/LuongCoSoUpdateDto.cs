using QLGV.Models;
using QLGV.Views.BangLuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.Luong
{
    public class LuongCoSoUpdateDto
    {
        public string LuongCoSo { get; set; }
        public static LuongCoSoUpdateDto FromView(LuongCoSoEdit view)
        {
            return new LuongCoSoUpdateDto
            {
                LuongCoSo = view.LuongCoSo,
            };
        }

        public LuongCoSoModel ToModel()
        {
            return new LuongCoSoModel
            {
                LuongCoSo = int.Parse(LuongCoSo)
            };
        }
    }
}
