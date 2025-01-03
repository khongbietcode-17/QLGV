﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    public class GiaoVienModel: BaseModel
    {
        public int GiaoVienId { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public int GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int BoMonId { get; set; }
        public BoMonModel BoMon { get; set; }
        public List<ChucVuModel> ChucVu { get; set; }
        public BangLuongModel BangLuong { get; set; }
    }
}
