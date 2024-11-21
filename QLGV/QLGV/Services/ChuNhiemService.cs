using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Services
{
    public class ChuNhiemService
    {
        private readonly IChuNhiemRepository _repository;
        public ChuNhiemService()
        {
            _repository = new ChuNhiemRepository();
        }

        public IEnumerable<ChuNhiemModel> GetAll()
        {
            var chuNhiem = _repository.Find(BaseFindCreterias.Empty());
            _repository.IncludeGiaoVien(chuNhiem);
            return chuNhiem;
        }
    }
}
