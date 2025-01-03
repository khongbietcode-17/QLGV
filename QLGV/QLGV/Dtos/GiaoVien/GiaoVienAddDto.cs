﻿using QLGV.Models;
using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.GiaoVien
{
    public class GiaoVienAddDto
    {
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

        public static GiaoVienAddDto FromView(IGiaoVienAdd view)
        {
            return new GiaoVienAddDto()
            {
                HoLot = view.HoLot.Trim(),
                Ten = view.Ten.Trim(),
                GioiTinh = view.RadioNam ? 1 : 2,
                NgaySinh = view.NgaySinh,
                DiaChi = view.DiaChi.Trim(),
                Email = view.Email.Trim(),
                SoDienThoai = view.SoDienThoai.Trim(),
                BoMon = view.BoMon,
                ChucVu = view.ChucVu,
                HeSoLuong = view.HeSoLuong.Trim(),
                HeSoPhuCap = view.HeSoPhuCap.Trim(),
            };
        }

        public GiaoVienModel ToModel()
        {
            return new GiaoVienModel()
            {
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
