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
    public class BoMonAddPresenter
    {
        private readonly BoMonAdd _view;
        private readonly BoMonService _service;
        public BoMonAddPresenter(BoMonAdd view) 
        {
            _view = view;
            _service = new BoMonService();
            _view.Add += HandleAdd;
        }

        public void HandleAdd(object o, EventArgs args)
        {
            if (_service.AddOne(BoMonAddDto.FromView(_view)))
            {
                _view.ResetForm();
            };
        }

    }
}
