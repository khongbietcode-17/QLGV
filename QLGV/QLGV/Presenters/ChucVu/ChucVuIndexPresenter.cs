using QLGV.Dtos.ChucVu;
using QLGV.Services;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.ChucVu
{
    public class ChucVuIndexPresenter
    {
        private readonly ChucVuIndex _view;
        private readonly ChucVuService _service;
        public ChucVuIndexPresenter(ChucVuIndex view) 
        {
            _view = view;
            _service = new ChucVuService();           
            _view.LoadData(GetDataFromService());
        }

        private List<ChucVuTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => ChucVuTableDto.FromModel(item));
        }
    }
}
