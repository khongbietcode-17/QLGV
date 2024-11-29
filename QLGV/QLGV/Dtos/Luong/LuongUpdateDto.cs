using QLGV.Models;
using QLGV.Views.BangLuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.Luong
{
    public class LuongUpdateDto
    {
        public int Id { get; set; }
        public string HeSoLuong { get; set; }
        public string HeSoPhuCap { get; set; }
        public int Luong { get; set; }
        public static LuongUpdateDto FromView(ILuongEdit view)
        {
            return new LuongUpdateDto
            {
                Id = view.InitId,        
                HeSoLuong = view.HeSoLuong,
                HeSoPhuCap = view.HeSoPhuCap,
            };
        }

        public BangLuongModel ToModel()
        {
            return new BangLuongModel
            {
                GiaoVienId = Id,
                HeSoLuong = Math.Round(decimal.Parse(HeSoLuong), 1),
                HeSoPhuCap = Math.Round(decimal.Parse(HeSoPhuCap), 1),
            };
        }
    }
}
