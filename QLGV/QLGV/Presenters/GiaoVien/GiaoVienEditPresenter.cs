using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos.GiaoVien;
using QLGV.Services;
using QLGV.Views.GiaoVien;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienEditPresenter
    {
        private readonly GiaoVienEdit _view;
        public readonly GiaoVienService _service;
        public readonly BoMonService _bomonService;
        public GiaoVienEditPresenter(GiaoVienEdit view) 
        {
            _view = view;
            _service = new GiaoVienService();
            _bomonService = new BoMonService();
            int id = _view.InitId;           
            _view.InitData(_service.GetOne(id), _bomonService.GetAll());
            _view.OnUpdate += UpdateGiaoVien;
        }

        public void UpdateGiaoVien(object sender, EventArgs e)
        {
            GiaoVienUpdateDto giaoVienDto = GiaoVienUpdateDto.FromView(_view);
            _service.UpdateOne(giaoVienDto);
        }
    }
}
