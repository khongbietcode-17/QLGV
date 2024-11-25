using QLGV.Dtos.ChucVu;
using QLGV.Dtos.Luong;
using QLGV.Validations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations
{
    public class LuongValidation: BaseValidation
    {
        public bool Validate(LuongUpdateDto dto)
        {
            
            if (string.IsNullOrEmpty(dto.HeSoLuong))
            {
                return HandleError("Vui lòng nhập Hệ Số Phụ Cấp");
            }
            if (string.IsNullOrEmpty(dto.HeSoPhuCap))
            {
                return HandleError("Vui lòng nhập Hệ Số Phụ Cấp");
            }
            try
            {
                var heSoLuong = decimal.Parse(dto.HeSoLuong);
                var heSoPhuCap = decimal.Parse(dto.HeSoPhuCap);
            } catch(FormatException)
            {
                return HandleError("Hệ số chưa đúng định dạng số");
            }
            return true;
        }
    }
}
