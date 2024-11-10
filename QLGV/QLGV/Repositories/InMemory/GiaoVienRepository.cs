using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.InMemory
{
    public class GiaoVienRepository : IGiaoVienRepository
    {
        public IEnumerable<GiaoVienModel> Find()
        {
            List<GiaoVienModel> giaoViens = new List<GiaoVienModel>()
            {
                new GiaoVienModel() {
                    GiaoVienId = 1,
                    HoLot = "Lê Văn",
                    Ten = "Toàn",
                    GioiTinh = 1,
                    DiaChi = "Ho Chi Minh",
                    Email = "toan@gmail.com",
                    SoDienThoai = "02832849023",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 2,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 2,
                    HoLot = "Nguyễn Thị",
                    Ten = "Hương",
                    GioiTinh = 0,
                    DiaChi = "Hanoi",
                    Email = "huong.nguyen@example.com",
                    SoDienThoai = "02412345678",            
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 3,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 3,
                    HoLot = "Trần Quang",
                    Ten = "Dũng",
                    GioiTinh = 1,
                    DiaChi = "Da Nang",
                    Email = "dungtran@email.com",
                    SoDienThoai = "02361234567",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 1,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 4,
                    HoLot = "Phạm Minh",
                    Ten = "Tú",
                    GioiTinh = 0,
                    DiaChi = "Hai Phong",
                    Email = "tu.pham@school.com",
                    SoDienThoai = "02251234567",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 4,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 5,
                    HoLot = "Bùi Anh",
                    Ten = "Tuấn",
                    GioiTinh = 1,
                    DiaChi = "Can Tho",
                    Email = "tuan.bui@school.vn",
                    SoDienThoai = "02923849562",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 2,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 6,
                    HoLot = "Lê Minh",
                    Ten = "Quân",
                    GioiTinh = 1,
                    DiaChi = "Hue",
                    Email = "quan.le@university.vn",
                    SoDienThoai = "02348275694",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 3,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 7,
                    HoLot = "Vũ Thị",
                    Ten = "Lan",
                    GioiTinh = 0,
                    DiaChi = "Nha Trang",
                    Email = "lan.vu@domain.com",
                    SoDienThoai = "02583276545",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 1,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 8,
                    HoLot = "Ngô Tiến",
                    Ten = "Duy",
                    GioiTinh = 1,
                    DiaChi = "Vinh",
                    Email = "duy.ngo@vnu.edu.vn",
                    SoDienThoai = "02398345678",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 4,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 9,
                    HoLot = "Đỗ Quốc",
                    Ten = "Bảo",
                    GioiTinh = 1,
                    DiaChi = "Quang Ngai",
                    Email = "bao.dq@outlook.com",
                    SoDienThoai = "02564321099",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 3,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 10,
                    HoLot = "Lý Khánh",
                    Ten = "Trang",
                    GioiTinh = 0,
                    DiaChi = "Bac Ninh",
                    Email = "trang.ly@gmail.com",
                    SoDienThoai = "02498765432",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 2,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 11,
                    HoLot = "Hoàng Minh",
                    Ten = "Tâm",
                    GioiTinh = 1,
                    DiaChi = "Bac Giang",
                    Email = "tam.hoang@vn.edu.vn",
                    SoDienThoai = "02455123698",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 1,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                },
                new GiaoVienModel() {
                    GiaoVienId = 12,
                    HoLot = "Trương Thị",
                    Ten = "Mai",
                    GioiTinh = 0,
                    DiaChi = "Thanh Hoa",
                    Email = "mai.truong@school.edu.vn",
                    SoDienThoai = "02344323344",
                    NgaySinh = new DateTime(1978, 10, 01),
                    BoMonId = 4,
                    BoMon = new BoMonModel()
                    {
                        BoMonId = 2,
                        TenBoMon = "Toán"
                    }
                }

            };

            return giaoViens;
        }
    }
}
