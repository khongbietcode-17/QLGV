using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using System.Collections.Generic;

namespace QLGV.Services
{
    public class BangLuongService
    {
        private readonly IBangLuongRepository _repository;

        public BangLuongService()
        {
            _repository = new BangLuongRepository();
        }

        public IEnumerable<BangLuongModel> GetAll()
        {

            var bangLuong = _repository.Find(BaseFindCreterias.Empty());
            _repository.IncludeGiaoVien(bangLuong);
            return bangLuong;
        }
    }
}
