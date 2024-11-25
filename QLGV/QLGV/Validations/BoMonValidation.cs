using QLGV.Dtos.BoMon;
using QLGV.Validations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations
{
    public class BoMonValidation: BaseValidation
    {
        public bool Validate(BoMonAddDto dto)
        {
            if(string.IsNullOrEmpty(dto.TenBoMon))
            {
                return HandleError("Vui lòng nhập Tên Bộ Môn");
            }
            return true;
        }
        public bool Validate(BoMonUpdateDto dto)
        {
            if (string.IsNullOrEmpty(dto.TenBoMon))
            {
                return HandleError("Vui lòng nhập Tên Bộ Môn");
            }
            return true;
        }
    }
}
