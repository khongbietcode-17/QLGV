using QLGV.Dtos.ChucVu;
using QLGV.Dtos.GiaoVien;
using QLGV.Services;
using QLGV.Views.ChucVu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters.ChucVu
{
    public class ChucVuIndexPresenter
    {
        private readonly ChucVuIndex _view;
        private readonly ChucVuService _service;
        public ChucVuIndexPresenter(ChucVuIndex view) 
        {
            _view = view;
            _service = new ChucVuService();
            _view.OnDelete += HandleDelete;
            InitData();
        }

        private List<ChucVuTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => ChucVuTableDto.FromModel(item));
        }

        public void InitData()
        {
            var chucVu = _service.GetAll();
            _view.LoadData(chucVu.ToList().ConvertAll(item => ChucVuTableDto.FromModel(item)));
        }

        public void HandleDelete(object sender, EventArgs e)
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
