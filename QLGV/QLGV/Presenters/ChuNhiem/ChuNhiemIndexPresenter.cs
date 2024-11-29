using QLGV.Dtos.ChuNhiem;
using QLGV.Services;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLGV.Presenters.ChuNhiem
{
    public class ChuNhiemIndexPresenter
    {
        private readonly IChuNhiemIndex _view;
        private readonly ChuNhiemService _service;
        public ChuNhiemIndexPresenter(ChuNhiemIndex view) 
        {
            _view = view;
            _service = new ChuNhiemService();
            _view.LoadData(GetDataFromService());
            _view.OnDelete += OnDelete;
        }

        private List<ChuNhiemTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => ChuNhiemTableDto.FromModel(item));
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var rows = _view.GetSelectedRow();
            int[] ids = new int[rows.Count];
            for (int i = 0; i < rows.Count; i++)
            {
                ids[i] = int.Parse(rows[i].Cells[0].Value.ToString());
            }
            _service.DeleteMany(ids);
            _view.clearSelection();
            _view.LoadData(GetDataFromService());
        }
    }
}
