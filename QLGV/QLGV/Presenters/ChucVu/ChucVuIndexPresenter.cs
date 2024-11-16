using QLGV.Services;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.ChucVu
{
    public class ChucVuIndexPresenter
    {
        private ChucVuIndex _view;
        private ChucVuService _service;
        public ChucVuIndexPresenter(ChucVuIndex view) 
        {
            _view = view;
            _service = new ChucVuService();
            _view.LoadData(_service.GetAll());
        }
    }
}
