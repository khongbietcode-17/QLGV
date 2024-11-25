using QLGV.Dtos.ChuNhiem;
using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using QLGV.Services;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.ChuNhiem
{
    public class ChuNhiemEditPresenter
    {
        private readonly ChuNhiemEdit _view;
        private readonly GiaoVienService _giaoVienService;
        private readonly ChuNhiemService _service;
        public ChuNhiemEditPresenter(ChuNhiemEdit view)
        {
            _view = view;
            _giaoVienService = new GiaoVienService();
            _service = new ChuNhiemService();
            _view.giaoVienList = _giaoVienService
                .GetAll()
                .ToList()
                .ConvertAll(item => GiaoVienSearchDto.FromModel(item));
            _view.InitData(InitData(_view.InitId));
            _view.OnUpdate += OnUpdate;
        }

        private ChuNhiemModel InitData(int id)
        {
            return _service.GetOne(id);
        }

        private void OnUpdate(object sender, EventArgs args)
        {
            ChuNhiemUpdateDto dto = ChuNhiemUpdateDto.FromView(_view);
            _service.UpdateOne(dto);
        }
    }
}
