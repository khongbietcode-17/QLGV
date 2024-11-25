using QLGV.Models;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.ChuNhiem
{
    public class ChuNhiemUpdateDto
    {
        public int Id { get; set; }
        public int GiaoVienId { get; set; }
        public string TenLop { get; set; }
        public string NamHoc { get; set; }

        public static ChuNhiemUpdateDto FromView(ChuNhiemEdit view)
        {
            return new ChuNhiemUpdateDto()
            {
                Id = view.InitId,
                GiaoVienId = view.GiaoVienId,
                TenLop = view.TenLop.Trim(),
                NamHoc = view.NamHoc.Trim(),
            };
        }

        public ChuNhiemModel ToModel()
        {
            return new ChuNhiemModel()
            {
                ChuNhiemId = Id,
                GiaoVienId= GiaoVienId,
                TenLop= TenLop,
                NamHoc= NamHoc,
            };
        }
    }
}
