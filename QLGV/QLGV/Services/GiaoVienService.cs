using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
using System.Collections.Generic;
using System.Linq;
using QLGV.Repositories.Creterias;
using QLGV.Dtos;
using QLGV.Validations;

namespace QLGV.Services
{
    public class GiaoVienService
    {
        private readonly IGiaoVienRepository _repository;
        private readonly GiaoVienAddValidation _addValidation;
        public GiaoVienService()
        {
            _repository = new GiaoVienRepository();
            _addValidation = new GiaoVienAddValidation();
        }

        public List<GiaoVienTableDto> GetAll()
        {
            var giaoViens = _repository.FindIncludeBoMon(BaseFindCreterias.Empty());

            return giaoViens.ToList().
                ConvertAll((giaoVien) => GiaoVienTableDto.FromModel(giaoVien));
        }

        public GiaoVien

        public bool AddOne(GiaoVienAddDto dto)
        {
            if(_addValidation.Validate(dto))
            {
                _repository.Add(dto.ToModel());
                return true;
            } else {
                return false;
            };
            
        }

        public int DeleteOne(string modelId)
        {
            int id = int.Parse(modelId);
            return _repository.Delete(id);
        }
    }
}
