using QLGV.Dtos.Luong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.BangLuong
{
    public interface ILuongIndex
    {
        event EventHandler OnSearch;
        string SearchKey { get; }
        string LuongCoSo { set; }
        void LoadData(IEnumerable<LuongTableDto> bangLuong);
        void clearSelection();
        int GetSelectedRowId();
    }
}
