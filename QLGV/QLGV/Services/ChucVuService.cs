using QLGV.Dtos.ChucVu;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Services
{
    public class ChucVuService
    {
        private IChucVuRepository _repository;

        public ChucVuService()
        {
            _repository = new ChucVuRepository();
        }

        public IEnumerable<ChucVuModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }
    }
}
