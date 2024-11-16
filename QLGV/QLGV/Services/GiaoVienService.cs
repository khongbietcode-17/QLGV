using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
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
        private readonly GiaoVienAddValidation _addValidation;
        private readonly GiaoVienUpdateValidation _updateValidation;
        public GiaoVienService()
        {
            _repository = new GiaoVienRepository();
            _addValidation = new GiaoVienAddValidation();
            _updateValidation  = new GiaoVienUpdateValidation();
        }

        public List<GiaoVienTableDto> GetAll()
        {
            var giaoViens = _repository.FindIncludeBoMon(BaseFindCreterias.Empty());

            return giaoViens.ToList().
                ConvertAll((giaoVien) => GiaoVienTableDto.FromModel(giaoVien));
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
