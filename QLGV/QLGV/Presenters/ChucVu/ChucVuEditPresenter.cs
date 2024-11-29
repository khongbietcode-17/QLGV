using QLGV.Dtos.ChucVu;
using QLGV.Services;
using QLGV.Views.ChucVu;
using System;


namespace QLGV.Presenters.ChucVu
{
    public class ChucVuEditPresenter
    {
        private readonly IChucVuEdit _view;
        private readonly ChucVuService _service;
        public ChucVuEditPresenter(ChucVuEdit view) 
        {
            _view = view;
            _service = new ChucVuService();
            int id = _view.InitId;
            _view.InitData(_service.GetOne(id));
            _view.OnUpdate += UpdateChucVu;

        }

        public void UpdateChucVu(object o, EventArgs args)
        {
            ChucVuUpdateDto dto = ChucVuUpdateDto.FromView(_view);
            _service.UpdateOne(dto);
        }


    }
}
