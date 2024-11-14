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
        private GiaoVienContainer _parentView;
        public GiaoVienAdd(GiaoVienContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            new GiaoVienAddPresenter(this);
            RaiseEvents();
        }

        private void RaiseEvents()
        {
            button1.Click += (o, e) => { Add?.Invoke(this, EventArgs.Empty);};
            txtHolot.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtTen.Focus();
                }
            };
            txtTen.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtDiachi.Focus();
                }
            };
            txtDiachi.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmail.Focus();
                }
            };
            txtEmail.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSdt.Focus();
                }
            };
            txtSdt.KeyDown += (o, e) =>
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

        public void ResetForm()
        {
            txtHolot.Clear();
            txtTen.Clear();
            radioNam.Checked = false;
            radioNu.Checked = true;
            comboBoxBoMon.SelectedItem = null;
            dateTimePickerNgaySinh.Value = DateTime.Now;
            txtDiachi.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new GiaoVienIndex(_parentView));
        }
    }

}
