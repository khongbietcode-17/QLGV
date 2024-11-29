using QLGV.Dtos.ChucVu;
using QLGV.Services;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.ChucVu
{
    public class ChucVuAddPresenter
    {
        private readonly IChucVuAdd _view;
        private readonly ChucVuService _service;
        public ChucVuAddPresenter(ChucVuAdd view)
        {
            _view = view;
            _service = new ChucVuService();
            _view.Add += HandleAdd;
        }

        public void HandleAdd(object o, EventArgs args)
        {
            if (_service.AddOne(ChucVuAddDto.FromView(_view)))
            {
                _view.ResetForm();
            };
        }
    }
}
