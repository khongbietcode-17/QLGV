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
        private readonly GiaoVienAdd _view;
        private readonly GiaoVienService _service;
        private readonly BoMonService _bomonService;
      
        public GiaoVienAddPresenter(GiaoVienAdd view) 
        {
            this._service = new GiaoVienService();
            this._bomonService = new BoMonService();
            this._view = view;
            this._view.SetDataSourceBoMon(GetBoMon());
            this._view.Add += AddGiaoVien;
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

    }
}
