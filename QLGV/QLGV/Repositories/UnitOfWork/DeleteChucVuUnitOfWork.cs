using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.UnitOfWork
{
    public class DeleteChucVuUnitOfWork
    {
        private IPhanCongRepository _phanCongRepository;
        private IChucVuRepository _chucVuRepository;

        public DeleteChucVuUnitOfWork()
        {
            _phanCongRepository = new PhanCongRepository();
            _chucVuRepository = new ChucVuRepository();
        }

        public int Delete(int[] ids)
        {
            _phanCongRepository.Delete(ids, "ChucVuId");
            return _chucVuRepository.Delete(ids);
        }
    }
}
