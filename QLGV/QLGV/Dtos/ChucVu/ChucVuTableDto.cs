using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.ChucVu
{
    public class ChucVuTableDto
    {
        public string Id { get; set; }
        public string TenChuVu { get; set; }

        public static ChucVuTableDto FromModel(ChucVuModel model)
        {
            return new ChucVuTableDto()
            {
                Id = model.ChucVuId.ToString(),
                TenChuVu = model.TenChucVu,               
            };
        }
    }
}
