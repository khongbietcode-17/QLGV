using QLGV.Dtos.ChuNhiem;
using QLGV.Services;
using QLGV.Views.ChuNhiem;
using System.Collections.Generic;
using System.Linq;

namespace QLGV.Presenters.ChuNhiem
{
    public class ChuNhiemIndexPresenter
    {
        private readonly ChuNhiemIndex _view;
        private readonly ChuNhiemService _service;
        public ChuNhiemIndexPresenter(ChuNhiemIndex view) 
        {
            _view = view;
            _service = new ChuNhiemService();
            _view.LoadData(GetDataFromService());
        }

        private List<ChuNhiemTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => ChuNhiemTableDto.FromModel(item));
        }
    }
}
