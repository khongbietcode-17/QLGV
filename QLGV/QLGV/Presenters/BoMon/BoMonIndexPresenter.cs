using QLGV.Views.BoMon;
using QLGV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos.BoMon;

namespace QLGV.Presenters.BoMon
{
    public class BoMonIndexPresenter
    {
        private readonly BoMonIndex _view;
        private readonly BoMonService _service;
        public BoMonIndexPresenter(BoMonIndex view) 
        { 
            _view = view;
            _service = new BoMonService();
            InitData();
        }

        public void InitData()
        {
            var list = _service.GetAll();
            _view.LoadData(list.ToList().ConvertAll(item => BoMonTableDto.FromModel(item)));
        }
    }
}
