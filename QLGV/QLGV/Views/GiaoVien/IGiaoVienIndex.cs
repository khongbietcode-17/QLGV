using QLGV.Dtos.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.GiaoVien
{
    public interface IGiaoVienIndex
    {
        event EventHandler OnDelete;
        void LoadData(IEnumerable<GiaoVienTableDto> giaoViens);
        DataGridViewSelectedRowCollection GetSelectedRow();
        int GetSelectedRowId();
        void clearSelection();
    }
}
