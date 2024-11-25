using QLGV.Dtos.ChuNhiem;
using QLGV.Dtos.GiaoVien;
using QLGV.Services;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;

namespace QLGV.Presenters.ChuNhiem
{
    public class ChuNhiemAddPresenter
    {
        private readonly ChuNhiemAdd _view;
        private readonly GiaoVienService _giaoVienService;
        private readonly ChuNhiemService _service;
        public ChuNhiemAddPresenter(ChuNhiemAdd view)
        {
            _view = view;
            _giaoVienService = new GiaoVienService();
            _service = new ChuNhiemService();
            _view.giaoVienList = _giaoVienService
                .GetAll()
                .ToList()
                .ConvertAll(item => GiaoVienSearchDto.FromModel(item));
            _view.OnAdd += HandleAdd;         
        }

        private void HandleAdd(object sender, EventArgs args)
        {
            ChuNhiemAddDto chuNhiem = ChuNhiemAddDto.FromView(_view);
            _service.AddOne(chuNhiem);
        }
    }
}
