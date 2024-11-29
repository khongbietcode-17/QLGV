using QLGV.Dtos.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.ChuNhiem
{
    public interface IChuNhiemIndex
    {
       event EventHandler OnDelete;
        void LoadData(IEnumerable<ChuNhiemTableDto> chuNhiems);
        DataGridViewSelectedRowCollection GetSelectedRow();
        int GetSelectedRowId();
        void clearSelection();
    }
}
