using QLGV.Models;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.ChucVu
{
    public class ChucVuAddDto
    {
        public string TenChucVu { get; set; }

        public static ChucVuAddDto FromView(ChucVuAdd view)
        {
            return new ChucVuAddDto()
            {
                TenChucVu = view.TenChucVu.Trim(),
            };
        }

        public ChucVuModel ToModel()
        {
            return new ChucVuModel()
            {
                TenChucVu = TenChucVu,
            };
        }
    }
}
