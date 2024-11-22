using QLGV.Dtos;
using QLGV.Models;
using QLGV.Presenters.GiaoVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.GiaoVien
{
    public partial class GiaoVienEdit : Form
    {
        private readonly GiaoVienContainer _containerView;

        public int InitId { get; set; } 

        public event EventHandler OnUpdate; 
        public GiaoVienEdit(int id, GiaoVienContainer containerView)
        {
            InitializeComponent();
            InitId = id;
            _containerView = containerView;
            new GiaoVienEditPresenter(this);
         
        }

        public void SetDataSourceBoMon(IEnumerable<BoMonModel> bomon)
        {
            comboBoxBoMon.ValueMember = null;
            comboBoxBoMon.DisplayMember = "TenBoMon";
            comboBoxBoMon.DataSource = bomon;
        }

        public void InitData(GiaoVienModel model, IEnumerable<BoMonModel> bomon)
        {
            txtId.Text = model.GiaoVienId.ToString();
            txtHolot.Text = model.HoLot;
            txtTen.Text = model.Ten;
            txtDiachi.Text = model.DiaChi;
            txtSdt.Text = model.SoDienThoai;
            txtEmail.Text = model.Email;
            dateTimePickerNgaySinh.Value = model.NgaySinh;
            SetDataSourceBoMon(bomon);
            BoMonModel boMon = bomon.FirstOrDefault(item => item.BoMonId == model.BoMonId);
            comboBoxBoMon.SelectedItem = boMon;
            if (model.GioiTinh == 1)
            {
                radioNam.Checked = true;
            } else
            {
                radioNu.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _containerView.SetChildren(new GiaoVienIndex(_containerView));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }
        public string Id { get => txtId.Text;  }
        public string HoLot { get => txtHolot.Text; }
        public string Ten { get => txtTen.Text; }
        public bool RadioNam { get => radioNam.Checked; }
        public bool RadioNu { get => radioNu.Checked; }
        public BoMonModel BoMon { get => (BoMonModel)comboBoxBoMon.SelectedItem; }
        public DateTime NgaySinh { get => dateTimePickerNgaySinh.Value; }
        public string DiaChi { get => txtDiachi.Text; }
        public string Email { get => txtEmail.Text; }
        public string SoDienThoai { get => txtSdt.Text; }
    }
}
