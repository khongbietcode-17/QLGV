﻿using QLGV.Dtos.GiaoVien;
using QLGV.Validations.Common;
using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Validations
{
    public class GiaoVienValidation: BaseValidation
    {
        public bool Validate(GiaoVienAddDto dto)
        {
            if(dto.HoLot == null || dto.HoLot == "") 
            {
                return HandleError("Vui lòng nhập họ");
            };
            if(dto.Ten == null || dto.Ten == "")
            {
                return HandleError("Vui lòng nhập tên");
            };
            if(dto.DiaChi == null || dto.DiaChi == "")
            {
                return HandleError("Vui lòng nhập địa chỉ");
            }
            if(dto.Email == null || dto.Email == "")
            {
                return HandleError("Vui lòng nhập email");
            }
            if(!EmailValidation.Validate(dto.Email))
            {
                return HandleError("Email không hợp lệ");
            }
            if(dto.SoDienThoai == null || dto.SoDienThoai == "")
            {
                return HandleError("Vui lòng nhập số điện thoại");
            } 
            if(!PhoneNumberValidation.Validate(dto.SoDienThoai))
            {
                return HandleError("Số điện thoại không hợp lệ");
            }
            try
            {
                var heSoLuong = decimal.Parse(dto.HeSoLuong);
                var heSoPhuCap = decimal.Parse(dto.HeSoPhuCap);
            }
            catch (FormatException)
            {
                return HandleError("Hệ số chưa đúng định dạng số");
            }

            return true;
        }

        public bool Validate(GiaoVienUpdateDto dto)
        {
            if (dto.HoLot == null || dto.HoLot == "")
            {
                return HandleError("Vui lòng nhập họ");
            };
            if (dto.Ten == null || dto.Ten == "")
            {
                return HandleError("Vui lòng nhập tên");
            };
            if (dto.DiaChi == null || dto.DiaChi == "")
            {
                return HandleError("Vui lòng nhập địa chỉ");
            }
            if (dto.Email == null || dto.Email == "")
            {
                return HandleError("Vui lòng nhập email");
            }
            if (!EmailValidation.Validate(dto.Email))
            {
                return HandleError("Email không hợp lệ");
            }
            if (dto.SoDienThoai == null || dto.SoDienThoai == "")
            {
                return HandleError("Vui lòng nhập số điện thoại");
            }
            if (!PhoneNumberValidation.Validate(dto.SoDienThoai))
            {
                return HandleError("Số điện thoại không hợp lệ");
            }
            try
            {
                var heSoLuong = decimal.Parse(dto.HeSoLuong);
                var heSoPhuCap = decimal.Parse(dto.HeSoPhuCap);
            }
            catch (FormatException)
            {
                return HandleError("Hệ số chưa đúng định dạng số");
            }
            return true;
        }

    }
}
