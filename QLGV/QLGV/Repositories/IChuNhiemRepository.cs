using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    public interface IChuNhiemRepository
    {
        IEnumerable<ChuNhiemModel> Find(BaseFindCreterias creterias);
        IEnumerable<ChuNhiemModel> IncludeGiaoVien(IEnumerable<ChuNhiemModel> chuNhiem);
    }
}
