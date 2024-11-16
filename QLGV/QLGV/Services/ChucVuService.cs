using QLGV.Dtos.ChucVu;
using QLGV.Models;
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
        private ChucVuRepository _repository;

        public ChucVuService()
        {
            _repository = new ChucVuRepository();
        }

        public List<ChucVuTableDto> GetAll()
        {
            IEnumerable<ChucVuModel> chucVuList = _repository.Find(BaseFindCreterias.Empty());
            return chucVuList.ToList()
                .ConvertAll(chuVu => ChucVuTableDto.FromModel(chuVu));
        }
    }
}
