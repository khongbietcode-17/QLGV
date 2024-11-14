using QLGV.Models;
using QLGV.Presenters.GiaoVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.GiaoVien
{
    public partial class GiaoVienAdd : Form
    { 
        public event EventHandler Add;
        public GiaoVienAdd()
        {
            InitializeComponent();
            new GiaoVienAddPresenter(this);
            RaiseEvents();
        }

        private void RaiseEvents()
        {
            button1.Click += (o, e) => { Add?.Invoke(this, EventArgs.Empty); };
            this.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                {
                    Add?.Invoke(this, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }
            };
        }

        public void SetDataSourceBoMon(IEnumerable<BoMonModel> bomon)
        {
            this.comboBoxBoMon.ValueMember = null;
            comboBoxBoMon.DisplayMember = "TenBoMon";
            comboBoxBoMon.DataSource = bomon;
        }

        public string HoLot { get => txtHolot.Text; }
        public string Ten { get => txtTen.Text; }
        public bool RadioNam { get => radioNam.Checked; }
        public bool RadioNu { get => radioNu.Checked; }
        public BoMonModel BoMon { get => (BoMonModel) comboBoxBoMon.SelectedItem; }
        public DateTime NgaySinh { get => dateTimePickerNgaySinh.Value; }       
        public string DiaChi {  get => txtDiachi.Text; }
        public string Email { get => txtEmail.Text; }
        public string SoDienThoai { get => txtSdt.Text; }
    }

}
