using QLGV.Models;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    public interface IGiaoVienRepository
    {
        IEnumerable<GiaoVienModel> Find(BaseFindCreterias creterias);
        IEnumerable<GiaoVienModel> FindIncludeBoMon(BaseFindCreterias creterias);
        GiaoVienModel Add(GiaoVienModel model);
        int Delete(int id);
        int Update(GiaoVienModel model);

        GiaoVienModel FindById(int id);
        GiaoVienModel FindByIdIncludeOne<BoMonModel>(int id);
    }
}
