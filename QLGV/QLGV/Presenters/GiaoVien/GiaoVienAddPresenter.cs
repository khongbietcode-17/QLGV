using QLGV.Views.GiaoVien;
using QLGV.Models;
using QLGV.Dtos.GiaoVien;
using QLGV.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Services;
using System.Windows.Forms;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienAddPresenter
    {
        private readonly IGiaoVienAdd _view;
        private readonly GiaoVienService _service;
        private readonly BoMonService _bomonService;
        private readonly ChucVuService _chucvuService;
      
        public GiaoVienAddPresenter(GiaoVienAdd view) 
        {
            _service = new GiaoVienService();
            _bomonService = new BoMonService();
            _chucvuService = new ChucVuService();
            _view = view;
            _view.SetDataSourceBoMon(GetBoMon());
            _view.SetDataSourceChucVu(GetChucVu());
            _view.Add += AddGiaoVien;
        }

        public void AddGiaoVien(object o, EventArgs e)
        {
            if(_service.AddOne(GiaoVienAddDto.FromView(_view)))
            {
                _view.ResetForm();
            };   
        }
        public IEnumerable<BoMonModel> GetBoMon()
        {
            return _bomonService.GetAll();
        }

        public IEnumerable<ChucVuModel> GetChucVu()
        {
            return _chucvuService.GetAll();
        }

    }
}
