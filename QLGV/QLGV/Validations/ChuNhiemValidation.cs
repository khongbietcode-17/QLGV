using QLGV.Dtos.ChuNhiem;
using QLGV.Validations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Validations
{
    public class ChuNhiemValidation: BaseValidation
    {
        public bool Validate(ChuNhiemAddDto dto)
        {
            if (dto.GiaoVienId == 0)
            {
                return HandleError("Vui lòng chọn Giáo viên");
            }
            if (string.IsNullOrEmpty(dto.TenLop))
            {
                return HandleError("Vui lòng nhập Tên Lớp");
            }
            if (string.IsNullOrEmpty(dto.NamHoc))
            {
                return HandleError("Vui lòng nhập Năm học");
            }
            return true;
        }

        public bool Validate(ChuNhiemUpdateDto dto)
        {
            if (dto.GiaoVienId == 0)
            {
                return HandleError("Vui lòng chọn Giáo viên");
            }
            if (string.IsNullOrEmpty(dto.TenLop))
            {
                return HandleError("Vui lòng nhập Tên Lớp");
            }
            if (string.IsNullOrEmpty(dto.NamHoc))
            {
                return HandleError("Vui lòng nhập Năm học");
            }
            return true;
        }
    }
}
