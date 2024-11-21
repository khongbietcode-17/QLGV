using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Models;

namespace QLGV.Dtos.Luong
{
    public class LuongTableDto
    {
        public string Id { get; set; }
        public string TenGiaoVien { get; set; }
        public string HeSoLuong { get; set; }
        public string HeSoPhuCap { get; set; } 
        public string Luong {  get; set; }
        public static LuongTableDto FromModel(BangLuongModel model)
        {
            return new LuongTableDto
            {
                Id = model.GiaoVienId.ToString(),
                TenGiaoVien = model.GiaoVien.HoLot + " " + model.GiaoVien.Ten,
                HeSoLuong = model.HeSoLuong.ToString(),
                HeSoPhuCap = model.HeSoPhuCap.ToString(),
                Luong = model.Luong.ToString(),
            };
        }
    }
}
