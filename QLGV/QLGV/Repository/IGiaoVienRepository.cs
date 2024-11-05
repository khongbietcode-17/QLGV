using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Model;

namespace QLGV.Repository
{
    internal interface IGiaoVienRepository
    {
        GiaoVien FindById(long id);
        IEnumerable<GiaoVien> GetAll();
        GiaoVien Add(GiaoVien giaoVien);
        int DeleteById(long id);
        int Update(GiaoVien giaoVien);
    }
}
