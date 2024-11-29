using QLGV.Dtos.Luong;
using QLGV.Services;
using QLGV.Views.BangLuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.Luong
{
    public class LuongEditPresenter
    {
        private readonly ILuongEdit _view;
        private readonly BangLuongService _service;
        public LuongEditPresenter(LuongEdit view)
        {
            _view = view;
            _service = new BangLuongService();
            _view.InitData(_service.GetOne(_view.InitId));
            _view.OnUpdate += HandleUpdate;
        }

        private void HandleUpdate(object sender, EventArgs args)
        {
            LuongUpdateDto dto = LuongUpdateDto.FromView(_view);
            _service.UpdateOne(dto);
        }
    }
}
