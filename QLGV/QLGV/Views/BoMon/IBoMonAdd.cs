using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.BoMon
{
    public interface IBoMonAdd
    {
        event EventHandler Add;
        string TenBoMon { get; }
        void ResetForm();
    }
}
