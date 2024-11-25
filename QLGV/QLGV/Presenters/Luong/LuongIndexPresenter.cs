using QLGV.Dtos.GiaoVien;
using QLGV.Dtos.Luong;
using QLGV.Services;
using QLGV.Views.BangLuong;
using QLGV.Views.ChuNhiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLGV.Presenters.Luong
{
    public class LuongIndexPresenter
    {
        private readonly LuongIndex _view;
        private readonly BangLuongService _service;
        private readonly LuongCoSoService _luongCoSoService;
        private List<LuongTableDto> _tables;

        public LuongIndexPresenter(LuongIndex view)
        {
            _view = view;
            _service = new BangLuongService();
            _luongCoSoService = new LuongCoSoService();
            _view.OnSearch += HandleSearch;
            _tables = GetDataFromService();
            _view.LoadData(_tables);
            _view.LuongCoSo = _luongCoSoService.GetLuongCoSo().ToString();
        }

        private List<LuongTableDto> GetDataFromService()
        {
            return _service.GetAll().ToList().ConvertAll(item => LuongTableDto.FromModel(item));
        }

        private void HandleSearch(object sender, EventArgs args)
        {
            string searchKey = _view.SearchKey;
            StringBuilder stringBuilder = new StringBuilder(".*");
            foreach (char i in searchKey)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(".*");
            }
            Regex regex = new Regex(stringBuilder.ToString(), RegexOptions.IgnoreCase);
            List<LuongTableDto> newList = _tables.Where(item => regex.IsMatch(item.TenGiaoVien)).ToList();
            _view.LoadData(newList);
        }

    }
}
