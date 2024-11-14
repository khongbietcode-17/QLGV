using QLGV.Views.GiaoVien;
using QLGV.Models;
using QLGV.Dtos;
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
        private IGiaoVienAdd _child;
        private readonly GiaoVienService _service;
        private readonly BoMonService _bomonService;
      
        public GiaoVienAddPresenter(IGiaoVienAdd child) 
        {
            this._service = new GiaoVienService();
            this._bomonService = new BoMonService();
            this._child = child;
            _child.SetDataSourceBoMon(GetBoMon());
            _child.Add += AddGiaoVien;
        }

        public void AddGiaoVien(object o, EventArgs e)
        {
            _service.AddOne(GiaoVienAddDto.FromView(_child));      
        }
        public IEnumerable<BoMonModel> GetBoMon()
        {
            return _bomonService.GetAll();
        }

    }
}
