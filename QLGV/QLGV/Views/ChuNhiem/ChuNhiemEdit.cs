using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using QLGV.Presenters.ChuNhiem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.ChuNhiem
{
    public partial class ChuNhiemEdit : Form
    {
        private readonly ChuNhiemContainer _parent;
        public event EventHandler OnUpdate;
        public IEnumerable<GiaoVienSearchDto> giaoVienList { get; set; }
        public GiaoVienSearchDto giaoVienSelected { get; set; }
        public int InitId {  get; set; }
        public int GiaoVienId { get ; set; }
        public string TenLop { get => txtTenLop.Text; set => txtTenLop.Text = value; }
        public string NamHoc {  get => txtNamHoc.Text; set => txtNamHoc.Text = value; }
        public ChuNhiemEdit(int initId, ChuNhiemContainer parent)
        {
            InitializeComponent();
            InitId = initId;
            _parent = parent;
            new ChuNhiemEditPresenter(this);
        }

        public void InitData(ChuNhiemModel model)
        {
            txtTenGiaoVien.Text = model.GiaoVien.HoLot + " " + model.GiaoVien.Ten;
            txtTenLop.Text = model.TenLop;
            txtNamHoc.Text = model.NamHoc;  
            GiaoVienId = model.GiaoVienId;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                return;
            }
            SetListboxValue(textBox1.Text);
        }

        private void SetListboxValue(string searchKey)
        {
            StringBuilder stringBuilder = new StringBuilder(".*");
            foreach (char i in searchKey)
            {
                stringBuilder.Append(i);
                stringBuilder.Append(".*");
            }
            Regex regex = new Regex(stringBuilder.ToString(), RegexOptions.IgnoreCase);
            List<GiaoVienSearchDto> newList = giaoVienList.Where(item => regex.IsMatch(item.HoTen)).ToList();
            listBox1.ValueMember = null;
            listBox1.DisplayMember = "HoTen";
            listBox1.DataSource = newList;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            giaoVienSelected = (GiaoVienSearchDto)listBox1.SelectedItem;
            GiaoVienId = giaoVienSelected.Id;
            txtTenGiaoVien.Text = giaoVienSelected.HoTen;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new ChuNhiemIndex(_parent));
        }
    }
}
