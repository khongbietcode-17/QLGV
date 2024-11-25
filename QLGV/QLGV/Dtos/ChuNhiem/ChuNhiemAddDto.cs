using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Views.ChuNhiem;

namespace QLGV.Dtos.ChuNhiem
{
    public class ChuNhiemAddDto
    {
        public int GiaoVienId { get; set; } 
        public string TenLop { get; set; }
        public string NamHoc { get; set; }

        public static ChuNhiemAddDto FromView(ChuNhiemAdd view)
        {
            return new ChuNhiemAddDto()
            {
                GiaoVienId = view.GiaoVienId,
                TenLop = view.TenLop.Trim(),
                NamHoc = view.NamHoc.Trim(),
            };
        }

        public ChuNhiemModel ToModel()
        {
            return new ChuNhiemModel()
            {
                GiaoVienId = GiaoVienId,
                TenLop = TenLop,
                NamHoc = NamHoc,
            };
        }
    }
}
