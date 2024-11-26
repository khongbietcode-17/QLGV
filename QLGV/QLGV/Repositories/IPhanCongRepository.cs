using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    internal interface IPhanCongRepository
    {
        int Delete(int[] ids);
        int Delete(int[] ids, string byColumn);
        int Add(PhanCongModel model);
        PhanCongModel FindFirst(BaseFindCreterias creterias);
        int Delete(BaseFindCreterias creterias);
    }
}
