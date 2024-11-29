using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.BoMon
{
    public interface IBoMonEdit
    {
        event EventHandler OnUpdate;
        int InitId { get; set; }
        string TenBoMon { get; }
        void InitData(BoMonModel model);
    }
}
