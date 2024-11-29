using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.GiaoVien
{
    public interface IGiaoVienAdd
    {
         event EventHandler Add;
         string HoLot { get; }
         string Ten { get; }
         bool RadioNam { get; }
         bool RadioNu { get ; }
         BoMonModel BoMon { get; }
         DateTime NgaySinh { get ; }
         string DiaChi { get; }
         string Email { get; }
         string SoDienThoai { get; }
         string HeSoLuong { get; }
         string HeSoPhuCap { get; }

         List<ChucVuModel> ChucVu { get;  }

        void SetDataSourceBoMon(IEnumerable<BoMonModel> bomon);
        void SetDataSourceChucVu(IEnumerable<ChucVuModel> chucVu);
        void ResetForm();
    }
}
