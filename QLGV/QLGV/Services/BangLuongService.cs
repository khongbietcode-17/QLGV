using QLGV.Dtos.Luong;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using QLGV.Validations;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace QLGV.Services
{
    public class BangLuongService
    {
        private readonly IBangLuongRepository _repository;
        private readonly LuongValidation _validation;
        private readonly LuongCoSoService _luongService;
        public BangLuongService()
        {
            _validation = new LuongValidation();
            _repository = new BangLuongRepository();
            _luongService = new LuongCoSoService();
        }

        public IEnumerable<BangLuongModel> GetAll()
        {

            var bangLuong = _repository.Find(BaseFindCreterias.Empty());
            _repository.IncludeGiaoVien(bangLuong);
            return bangLuong;
        }
        public BangLuongModel GetOne(int id)
        {
            BangLuongModel model = _repository.FindById(id);
            _repository.IncludeGiaoVien(model);
            return model;
        }

        public bool UpdateOne(LuongUpdateDto dto)
        {
            if (_validation.Validate(dto))
            {
                var model = dto.ToModel();
                int luongCoSo = _luongService.GetLuongCoSo();
                model.Luong = (int) (model.HeSoLuong * luongCoSo ) + (int) (model.HeSoPhuCap * luongCoSo);
                _repository.Update(model);
                return true;
            }
            else
            {
                return false;
            };
        }

        public bool UpdateOne(BangLuongModel model)
        {
            int luongCoSo = _luongService.GetLuongCoSo();
            model.Luong = (int)(model.HeSoLuong * luongCoSo) + (int)(model.HeSoPhuCap * luongCoSo);
            _repository.Update(model);
            return true;
        }

        public void AddOne(BangLuongModel model)
        {
            int luongCoSo = _luongService.GetLuongCoSo();
            model.Luong = (int)(model.HeSoLuong * luongCoSo) + (int)(model.HeSoPhuCap * luongCoSo);
            _repository.Add(model);
        }
    }
}
