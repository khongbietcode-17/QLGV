using QLGV.Dtos.ChucVu;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Validations.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Services
{
    public class ChucVuService
    {
        private readonly IChucVuRepository _repository;
        private readonly ChucVuAddValidation _addValidation;

        public ChucVuService()
        {
            _repository = new ChucVuRepository();
            _addValidation = new ChucVuAddValidation();
        }

        public IEnumerable<ChucVuModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }
        public bool AddOne(ChucVuAddDto dto)
        {
            if (_addValidation.Validate(dto))
            {
                _repository.Add(dto.ToModel());
                return true;
            }
            else
            {
                return false;
            };

        }
    }
}
