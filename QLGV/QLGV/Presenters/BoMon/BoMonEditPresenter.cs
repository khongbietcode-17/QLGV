using QLGV.Dtos.BoMon;
using QLGV.Services;
using QLGV.Views.BoMon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.BoMon
{
    public class BoMonEditPresenter
    {
        private readonly BoMonEdit _view;
        private readonly BoMonService _service;

        public BoMonEditPresenter(BoMonEdit view)
        {
            _view = view;
            _service = new BoMonService();
            int id =  _view.InitId;
            _view.InitData(_service.GetOne(id));
            _view.OnUpdate += UpdateBoMon;
        }

        public void UpdateBoMon(object o, EventArgs args)
        {
            BoMonUpdateDto dto = BoMonUpdateDto.FromView(_view);
            _service.UpdateOne(dto);
        }
    }
}
