using QLGV.Services;
using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienIndexPresenter
    {
        private readonly GiaoVienService _service;

        public GiaoVienIndexPresenter(IGiaoVienIndex _view)
        {
            _service = new GiaoVienService();
        }

    }
}
