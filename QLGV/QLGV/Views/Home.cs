using QLGV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLGV.Views
{
    public partial class Home : Form
    {
        public Chart ChartPie { get; set; }
        public string TongSoGiaoVien { get => label3.Text; set => label3.Text = value; }
        public string TongSoBoMon { get => label4.Text; set => label4.Text = value; }
        public Home()
        {
            InitializeComponent();
            ChartPie = chart1;
            new HomePresenter(this);
        }

    }
}
