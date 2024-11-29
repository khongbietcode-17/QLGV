using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.ChucVu
{
    public interface IChucVuAdd
    {
        event EventHandler Add;
        string TenChucVu { get; }
        void ResetForm();
    }
}
