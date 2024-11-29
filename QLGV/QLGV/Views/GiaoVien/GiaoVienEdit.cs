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
    public partial class GiaoVienEdit : Form, IGiaoVienEdit
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

        public void SetDataSourceChucVu(IEnumerable<ChucVuModel> chucVu)
        {
            checkedListBox1.ValueMember = null;
            checkedListBox1.DataSource = chucVu;
            checkedListBox1.DisplayMember = "TenChucVu";
        }

        public void InitData(GiaoVienModel model, IEnumerable<BoMonModel> bomon)
        {
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
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                ChucVuModel item = (ChucVuModel) checkedListBox1.Items[i];
                if (model.ChucVu.Contains(item))
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            txtHeSoLuong.Text = model.BangLuong.HeSoLuong.ToString();
            txtHeSoPhuCap.Text = model.BangLuong.HeSoPhuCap.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _containerView.SetChildren(new GiaoVienIndex(_containerView));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }
        public string HoLot { get => txtHolot.Text; }
        public string Ten { get => txtTen.Text; }
        public bool RadioNam { get => radioNam.Checked; }
        public bool RadioNu { get => radioNu.Checked; }
        public BoMonModel BoMon { get => (BoMonModel)comboBoxBoMon.SelectedItem; }
        public DateTime NgaySinh { get => dateTimePickerNgaySinh.Value; }
        public string DiaChi { get => txtDiachi.Text; }
        public string Email { get => txtEmail.Text; }
        public string SoDienThoai { get => txtSdt.Text; }
        public string HeSoLuong { get => txtHeSoLuong.Text; }
        public string HeSoPhuCap { get => txtHeSoPhuCap.Text; }
        public List<ChucVuModel> ChucVu
        {
            get
            {
                List<ChucVuModel> chucVu = new List<ChucVuModel>();

                foreach (var item in checkedListBox1.CheckedItems)
                {
                    chucVu.Add((ChucVuModel)item);
                }

                return chucVu;
            }
        }
    }
}
