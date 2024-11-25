using QLGV.Models;
using QLGV.Services;
using QLGV.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLGV.Presenters
{
    public class HomePresenter
    {
        public readonly Home _view;
        private readonly GiaoVienService _giaoVienService;
        private readonly BoMonService _boMonService;
        public HomePresenter(Home view)
        {
            _view = view;
            _giaoVienService = new GiaoVienService();
            _boMonService = new BoMonService();
            SetTongSoGiaoVien();
            SetTongSoBoMon();
            SetupChart();
        }

        public void SetTongSoGiaoVien()
        {
            _view.TongSoGiaoVien = _giaoVienService.Count().ToString();
        }

        public void SetTongSoBoMon()
        {
            _view.TongSoBoMon = _boMonService.Count().ToString();
        }

        public void SetupChart()
        {
            _view.ChartPie.Titles.Add("Cơ cấu Giáo Viên");

            IEnumerable<BoMonModel> boMons = _boMonService.GetAll();
            Dictionary<string,string> map = new Dictionary<string,string>();

            foreach (var boMon in boMons)
            {
                int count = _giaoVienService.CountWithBoMon(boMon.BoMonId);
                map.Add(boMon.TenBoMon, count.ToString());
            }

           
            foreach (var item in map)
            {
                if(item.Value == "0")
                {
                    continue;
                }
                _view.ChartPie.Series["s1"].Points.AddXY(item.Key, item.Value);
            }

            foreach (DataPoint point in _view.ChartPie.Series["s1"].Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]}";
            }

            //_view.ChartPie.Series["s1"]["PieLabelStyle"] = "Two Colums";
            //_view.ChartPie.Series["s1"]["PieLineColor"] = "Black";
        }
    }

}
