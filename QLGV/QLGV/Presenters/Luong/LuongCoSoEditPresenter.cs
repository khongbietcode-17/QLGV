

using QLGV.Dtos.Luong;
using QLGV.Services;
using QLGV.Views.BangLuong;
using System;

namespace QLGV.Presenters.Luong
{
    public class LuongCoSoEditPresenter
    {
        private LuongCoSoEdit _view;
        private readonly LuongCoSoService _service;
        public LuongCoSoEditPresenter(LuongCoSoEdit view)
        {
            _view = view;
            _service = new LuongCoSoService();
            _view.LuongCoSo = _service.GetLuongCoSo().ToString();
            _view.OnUpdate += HandleUpdate;
        }

        private void HandleUpdate(object sender, EventArgs args)
        {
            LuongCoSoUpdateDto dto = LuongCoSoUpdateDto.FromView(_view);
            _service.UpdateLuongCoSo(dto);
        }
    }
}
