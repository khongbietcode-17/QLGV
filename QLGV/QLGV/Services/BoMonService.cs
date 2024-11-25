using QLGV.Dtos.BoMon;
using QLGV.Dtos.GiaoVien;
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
    public class BoMonService
    {
        private readonly IBoMonRepository _repository;
        private readonly BoMonValidation _validation;


        public BoMonService()
        {
            _repository = new BoMonRepository();
            _validation = new BoMonValidation();
        }

        public IEnumerable<BoMonModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }

        public BoMonModel GetOne(int id)
        {
            return _repository.FindById(id);
        }

        public int DeleteMany(int[] ids)
        {
            return _repository.Delete(ids);
        }

        public bool AddOne(BoMonAddDto dto)
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

        public int Count()
        {
            return _repository.Count();
        }

        public bool UpdateOne(BoMonUpdateDto dto)
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
