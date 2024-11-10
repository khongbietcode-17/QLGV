using QLGV.Services;
using QLGV.Views.GiaoVien;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienIndexPresenter
    {
        private readonly IGiaoVienIndex _view; 
        private readonly GiaoVienService _service;

        public GiaoVienIndexPresenter(IGiaoVienIndex view)
        {
            _view = view;
            _service = new GiaoVienService();
            InitData();
        }

        public void InitData()
        {
            IEnumerable<GiaoVienModel> giaoViens = _service.GetAll();
            _view.LoadData(giaoViens
                .ToList().
                ConvertAll((giaoVien) => GiaoVienTableDto.FromModel(giaoVien)));
        }
    }
}
