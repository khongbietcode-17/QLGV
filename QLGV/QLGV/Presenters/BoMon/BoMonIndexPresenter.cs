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
            _view.OnDelete += HandleDelete;
        }

        public void InitData()
        {
            var list = _service.GetAll();
            _view.LoadData(list.ToList().ConvertAll(item => BoMonTableDto.FromModel(item)));
        }

        public void HandleDelete(object sender, EventArgs args)
        {
            var rows = _view.GetSelectedRow();
            int[] ids = new int[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                ids[i] = int.Parse(rows[i].Cells[0].Value.ToString());
            }
            _service.DeleteMany(ids);
            _view.clearSelection();
            InitData();
        }
    }
}
