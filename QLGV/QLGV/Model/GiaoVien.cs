using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Model
{
    internal class GiaoVien
    {
        public int Id { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public int GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public int BoMonId { get; set; }
    }
}
