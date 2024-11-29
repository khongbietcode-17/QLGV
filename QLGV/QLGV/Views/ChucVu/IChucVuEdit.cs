using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.ChucVu
{
    public interface IChucVuEdit
    {
        event EventHandler OnUpdate;
        void InitData(ChucVuModel model);
        int InitId { get; set; }
        string TenChucVu { get; }
    }
}
