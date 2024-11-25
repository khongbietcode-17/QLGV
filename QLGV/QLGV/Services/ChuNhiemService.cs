using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Dtos.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos.GiaoVien;
using QLGV.Repositories.UnitOfWork;
using QLGV.Validations;
using QLGV.Models;

namespace QLGV.Services
{
    public class ChuNhiemService
    {
        private readonly IChuNhiemRepository _repository;
        private readonly ChuNhiemValidation _validation;
        public ChuNhiemService()
        {
            _validation = new ChuNhiemValidation();
            _repository = new ChuNhiemRepository();
        }

        public IEnumerable<ChuNhiemModel> GetAll()
        {
            var chuNhiem = _repository.Find(BaseFindCreterias.Empty());
            _repository.IncludeGiaoVien(chuNhiem);
            return chuNhiem;
        }
        public bool AddOne(ChuNhiemAddDto dto)
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
            return _repository.Delete(ids);
        }

        public bool UpdateOne(ChuNhiemUpdateDto dto)
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
        public ChuNhiemModel GetOne(int id)
        {
            ChuNhiemModel model = _repository.FindById(id);
            _repository.IncludeGiaoVien(model);
            return model;
        }
    }
}
