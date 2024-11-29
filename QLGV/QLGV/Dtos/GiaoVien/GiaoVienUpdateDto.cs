using QLGV.Models;
using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.GiaoVien
{
     public class GiaoVienUpdateDto
    {
        public int Id { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public BoMonModel BoMon { get; set; }
        public List<ChucVuModel> ChucVu { get; set; }
        public string HeSoLuong { get; set; }
        public string HeSoPhuCap { get; set; }

        public static GiaoVienUpdateDto FromView(IGiaoVienEdit view)
        {
            return new GiaoVienUpdateDto()
            {
                Id = view.InitId,
                HoLot = view.HoLot.Trim(),
                Ten = view.Ten.Trim(),
                GioiTinh = view.RadioNam ? 1 : 2,
                NgaySinh = view.NgaySinh,
                DiaChi = view.DiaChi.Trim(),
                Email = view.Email.Trim(),
                SoDienThoai = view.SoDienThoai.Trim(),
                BoMon = view.BoMon,
                ChucVu = view.ChucVu,
                HeSoLuong = view.HeSoLuong,
                HeSoPhuCap = view.HeSoPhuCap
            };
        }

        public GiaoVienModel ToModel()
        {
            return new GiaoVienModel()
            {
                GiaoVienId = Id,
                HoLot = HoLot,
                Ten = Ten,
                GioiTinh = GioiTinh,
                NgaySinh = NgaySinh,
                DiaChi = DiaChi,
                Email = Email,
                SoDienThoai = SoDienThoai,
                BoMonId = BoMon.BoMonId,
                ChucVu = ChucVu,
                BangLuong = new BangLuongModel()
                {
                    HeSoLuong = decimal.Parse(HeSoLuong),
                    HeSoPhuCap = decimal.Parse(HeSoPhuCap)
                },
            };
        }
    }
}
