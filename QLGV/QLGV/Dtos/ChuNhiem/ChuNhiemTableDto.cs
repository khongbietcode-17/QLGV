using QLGV.Dtos.ChucVu;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.ChuNhiem
{
    public class ChuNhiemTableDto
    {
        public string Id { get; set; }
        public string TenGiaoVien { get; set; }
        public string TenLop { get; set; }
        public string NamHoc { get; set; }


        public static ChuNhiemTableDto FromModel(ChuNhiemModel model)
        {
            return new ChuNhiemTableDto()
            {
                Id = model.ChuNhiemId.ToString(),
                TenGiaoVien = model.GiaoVien.HoLot + " " + model.GiaoVien.Ten,
                TenLop = model.TenLop,
                NamHoc = model.NamHoc,
            };
        }
    }
}
