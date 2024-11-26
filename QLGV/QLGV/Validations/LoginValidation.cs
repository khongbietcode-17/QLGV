using QLGV.Dtos;
using QLGV.Validations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations
{
    public class LoginValidation: BaseValidation
    {
        public bool Validate(LoginDto dto)
        {
           
            if (string.IsNullOrEmpty(dto.UserName))
            {
                return HandleError("Vui lòng nhập Username");
            }
            if (string.IsNullOrEmpty(dto.Password))
            {
                return HandleError("Vui lòng nhập Password");
            }
            return true;
        }
    }
}
