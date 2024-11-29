using QLGV.Dtos.BoMon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.BoMon
{
    public interface IBoMonIndex
    {
        event EventHandler OnDelete;
        void LoadData(IEnumerable<BoMonTableDto> list);
        int GetSelectedRowId();
        DataGridViewSelectedRowCollection GetSelectedRow();
        void clearSelection();
    }
}
