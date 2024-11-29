using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views.BangLuong
{
    public interface ILuongEdit
    {
        event EventHandler OnUpdate;
        int InitId { get; set; }
        string HeSoLuong { get; set; }
        string HeSoPhuCap { get; set; }
        void InitData(BangLuongModel model);
    }
}
