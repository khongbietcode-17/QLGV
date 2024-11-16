using QLGV.Services;
using QLGV.Views.GiaoVien;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos.GiaoVien;
using System.Windows.Forms;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienIndexPresenter
    {
        private readonly GiaoVienIndex _view; 
        private readonly GiaoVienService _service;

        public GiaoVienIndexPresenter(GiaoVienIndex view)
        {
            _view = view;
            _service = new GiaoVienService();
            _view.OnDelete += OnDelete;
            InitData();
        }

        public void InitData()
        {
            List<GiaoVienTableDto> giaoViens = _service.GetAll();
            _view.LoadData(giaoViens);
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var rows = _view.GetSelectedRow();
            if (rows.Count == 1)
            {
                _service.DeleteOne(rows[0].Cells[0].Value.ToString());
                _view.clearSelection();
                InitData();
            };
        }
    }
}
