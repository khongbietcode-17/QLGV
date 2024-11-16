using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.GiaoVien
{
    public class GiaoVienTableDto
    {
        public string Id { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string TenBoMon { get; set; }

        public static GiaoVienTableDto FromModel(GiaoVienModel model)
        {
            return new GiaoVienTableDto()
            {
                Id = model.GiaoVienId.ToString(),
                HoLot = model.HoLot,
                Ten = model.Ten,
                GioiTinh = model.GioiTinh == 0 ? "" : model.GioiTinh == 1 ? "Nam": "Nữ",
                NgaySinh = model.NgaySinh.ToString("dd/MM/yyyy"),
                DiaChi = model.DiaChi,
                Email = model.Email,
                SoDienThoai = model.SoDienThoai,
                TenBoMon = model.BoMon != null ? model.BoMon.TenBoMon : "",
            };
        }

    }
}
