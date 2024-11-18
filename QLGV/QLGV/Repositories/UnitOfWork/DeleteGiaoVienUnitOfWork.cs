using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.UnitOfWork
{
    public class DeleteGiaoVienUnitOfWork
    {
        private IPhanCongRepository _phanCongRepository;
        private IGiaoVienRepository _giaoVienRepository;
        public DeleteGiaoVienUnitOfWork() 
        {
            _phanCongRepository = new PhanCongRepository();
            _giaoVienRepository = new GiaoVienRepository();
        }

        public int Delete(int[] ids)
        {
            _phanCongRepository.Delete(ids);
            return _giaoVienRepository.Delete(ids);
        }
    }
}
