using QLGV.Models;
using QLGV.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.GiaoVien
{
    public interface IGiaoVienIndex
    {
        void LoadData(IEnumerable<GiaoVienTableDto> giaoViens);
    }
}
