using QLGV.Dtos.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.ChucVu
{
    public interface IChucVuIndex
    {
        event EventHandler OnDelete;
        void LoadData(IEnumerable<ChucVuTableDto> chucVuList);
        void ClearSelection();
        DataGridViewSelectedRowCollection GetSelectedRow();
        int GetSelectedRowId();
        void clearSelection();
    }
}
