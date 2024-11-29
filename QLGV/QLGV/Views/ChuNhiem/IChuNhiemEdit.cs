using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.ChuNhiem
{
    public interface IChuNhiemEdit
    {
        event EventHandler OnUpdate;
        IEnumerable<GiaoVienSearchDto> giaoVienList { get; set; }
        GiaoVienSearchDto giaoVienSelected { get; set; }
        int InitId { get; set; }
        int GiaoVienId { get; set; }
        string TenLop { get; set; }
        string NamHoc { get; set; }
        void InitData(ChuNhiemModel model);
    }
}
