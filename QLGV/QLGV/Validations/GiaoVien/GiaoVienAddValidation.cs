using QLGV.Dtos.GiaoVien;
using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Validations
{
    public class GiaoVienAddValidation
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

            return true;
        }

        private bool HandleError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}
