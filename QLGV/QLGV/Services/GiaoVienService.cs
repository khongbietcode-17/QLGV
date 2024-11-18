using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
using QLGV.Repositories.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using QLGV.Repositories.Creterias;
using QLGV.Dtos.GiaoVien;
using QLGV.Validations;
using QLGV.Models;

namespace QLGV.Services
{
    public class GiaoVienService
    {
        private readonly IGiaoVienRepository _repository;
        private readonly DeleteGiaoVienUnitOfWork _deleteUnitOfWork;
        private readonly GiaoVienAddValidation _addValidation;
        private readonly GiaoVienUpdateValidation _updateValidation;
        public GiaoVienService()
        {
            _repository = new GiaoVienRepository();
            _addValidation = new GiaoVienAddValidation();
            _updateValidation  = new GiaoVienUpdateValidation();
            _deleteUnitOfWork = new DeleteGiaoVienUnitOfWork();
        }

        public IEnumerable<GiaoVienModel> GetAll()
        {
            IEnumerable<GiaoVienModel> giaoVien = _repository.Find(BaseFindCreterias.Empty());
            _repository.IncludeBoMon(giaoVien);
            _repository.IncludeChucVu(giaoVien);
            return giaoVien;    
        }

        public GiaoVienModel GetOne(int id)
        {
            return _repository.FindByIdIncludeOne<BoMonModel>(id);
        }

        public bool AddOne(GiaoVienAddDto dto)
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

        public int DeleteOne(string modelId)
        {
            int id = int.Parse(modelId);
            return _repository.Delete(id);
        }

        public int DeleteMany(int[] ids) 
        {
            return _deleteUnitOfWork.Delete(ids);
        }

        public bool UpdateOne(GiaoVienUpdateDto dto)
        {
            if (_updateValidation.Validate(dto))
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
