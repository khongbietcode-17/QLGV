using QLGV.Dtos.Luong;
using QLGV.Services;
using QLGV.Views.BangLuong;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.Luong
{
    public class LuongIndexPresenter
    {
        private readonly LuongIndex _view;
        private readonly BangLuongService _service;

        public LuongIndexPresenter(LuongIndex view)
        {
            _view = view;
            _service = new BangLuongService();
            _view.LoadData(GetDataFromService());
        }

        private List<LuongTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => LuongTableDto.FromModel(item));
        }

    }
}
