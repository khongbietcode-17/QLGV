using QLGV.Dtos.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.ChuNhiem
{
    public interface IChuNhiemAdd
    {
        event EventHandler OnAdd;
        IEnumerable<GiaoVienSearchDto> giaoVienList { get; set; }
        GiaoVienSearchDto giaoVienSelected { get; set; }
        int GiaoVienId { get; }
        string TenLop { get; }
        string NamHoc { get; }
        void ResetForm();
    }
}
