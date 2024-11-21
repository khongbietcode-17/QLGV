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
            var giaoViens = _service.GetAll();
            _view.LoadData(giaoViens.ToList().ConvertAll(item => GiaoVienTableDto.FromModel(item)));
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
            InitData();          
        }
    }
}
