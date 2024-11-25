using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
using QLGV.Repositories.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using QLGV.Repositories.Creterias;
using QLGV.Dtos.GiaoVien;
using QLGV.Validations;
using QLGV.Models;
using System;

namespace QLGV.Services
{
    public class GiaoVienService
    {
        private readonly IGiaoVienRepository _repository;
        private readonly DeleteGiaoVienUnitOfWork _deleteUnitOfWork;
        private readonly CreateGiaoVienUnitOfWork _createGiaoVienUnitOfWork;
        private readonly GiaoVienValidation _validation;
       
        public GiaoVienService()
        {
            _repository = new GiaoVienRepository();
            _validation = new GiaoVienValidation();  
            _deleteUnitOfWork = new DeleteGiaoVienUnitOfWork();
            _createGiaoVienUnitOfWork = new CreateGiaoVienUnitOfWork();
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
            GiaoVienModel model = _repository.FindById(id);
            _repository.IncludeBoMon(model);
            return model;
        }

        public bool AddOne(GiaoVienAddDto dto)
        {
            if (_validation.Validate(dto))
            {
                //_repository.Add(dto.ToModel());
                _createGiaoVienUnitOfWork.Create(dto.ToModel());
                return true;
            }
            else
            {
                return false;
            };

        }

        public int DeleteMany(int[] ids) 
        {
            return _deleteUnitOfWork.Delete(ids);
        }

        public int Count()
        {
            return _repository.Count();
        }
        public int CountWithBoMon(int BoMonId)
        {
            return _repository.Count("BoMonId", BoMonId.ToString());
        }

        public bool UpdateOne(GiaoVienUpdateDto dto)
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
