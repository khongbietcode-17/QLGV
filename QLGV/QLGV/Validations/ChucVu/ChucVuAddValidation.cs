using QLGV.Dtos.ChucVu;
using QLGV.Validations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations.ChucVu
{
    public class ChucVuAddValidation: BaseValidation
    {
        public bool Validate(ChucVuAddDto dto)
        {
            if (string.IsNullOrEmpty(dto.TenChucVu))
            {
                return HandleError("Vui lòng nhập Tên Chức Vụ");
            }
            return true;
        }
    }
}
