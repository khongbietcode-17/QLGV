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
        ChuNhiemModel FindById(int id);
        IEnumerable<ChuNhiemModel> IncludeGiaoVien(IEnumerable<ChuNhiemModel> chuNhiem);
        ChuNhiemModel IncludeGiaoVien(ChuNhiemModel chuNhiem);
        int Add(ChuNhiemModel model);
        int Delete(int[] id);
        int Delete(int[] id, string byColumn);
        int Update(ChuNhiemModel model);
    }
}
