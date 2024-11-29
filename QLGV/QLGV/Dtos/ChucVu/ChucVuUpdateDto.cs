using QLGV.Models;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.ChucVu
{
    public class ChucVuUpdateDto
    {
        public int Id { get; set; }
        public string TenChucVu { get; set; }

        public static ChucVuUpdateDto FromView(IChucVuEdit view)
        {
            return new ChucVuUpdateDto()
            {
                Id = view.InitId,
                TenChucVu = view.TenChucVu.Trim(),
            };
        }

        public ChucVuModel ToModel()
        {
            return new ChucVuModel()
            {
                ChucVuId = Id,
                TenChucVu = TenChucVu,
            };
        }
    }
}
