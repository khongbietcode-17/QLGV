using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    public interface IChucVuRepository
    {
        IEnumerable<ChucVuModel> Find(BaseFindCreterias creterias);

        int Add(ChucVuModel model);
        ChucVuModel FindById(int id);
        int Update(ChucVuModel model);
        int Delete(int[] ids);
    }
}
