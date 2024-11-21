using QLGV.Dtos.BoMon;
using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Repositories.UnitOfWork;
using QLGV.Validations.BoMon;
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
        private readonly BoMonAddValidation _addValidation;

        public BoMonService()
        {
            _repository = new BoMonRepository();
            _addValidation = new BoMonAddValidation();
        }

        public IEnumerable<BoMonModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }

        public bool AddOne(BoMonAddDto dto)
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
