using QLGV.Dtos.BoMon;
using QLGV.Dtos.ChucVu;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Repositories.UnitOfWork;
using QLGV.Validations;
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
        private readonly DeleteChucVuUnitOfWork _deleteChucVu;
        private readonly ChucVuValidation _validation;

        public ChucVuService()
        {
            _repository = new ChucVuRepository();
            _validation = new ChucVuValidation();
            _deleteChucVu = new DeleteChucVuUnitOfWork();
        }

        public IEnumerable<ChucVuModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }

        public ChucVuModel GetOne(int id)
        {
            return _repository.FindById(id);
        }
        public bool AddOne(ChucVuAddDto dto)
        {
            if (_validation.Validate(dto))
            {
                _repository.Add(dto.ToModel());
                return true;
            }
            else
            {
                return false;
            };

        }

        public int DeleteMany(int[] ids)
        {
            return _deleteChucVu.Delete(ids);
        }
        public bool UpdateOne(ChucVuUpdateDto dto)
        {
            if (_validation.Validate(dto))
            {
                _repository.Update(dto.ToModel());
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}
