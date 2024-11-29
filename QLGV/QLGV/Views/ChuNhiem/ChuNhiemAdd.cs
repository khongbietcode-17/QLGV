using QLGV.Dtos.GiaoVien;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLGV.Views.ChuNhiem
{
    public partial class ChuNhiemAdd : Form, IChuNhiemAdd
    {
        public IEnumerable<GiaoVienSearchDto> giaoVienList { get; set; }
        public GiaoVienSearchDto giaoVienSelected { get; set; }       
        public int GiaoVienId { get => giaoVienSelected.Id; }
        public string TenLop { get => txtTenLop.Text;}
        public string NamHoc { get => txtNamHoc.Text;}

        private ChuNhiemContainer _parent;

        public event EventHandler OnAdd;

        public ChuNhiemAdd(ChuNhiemContainer parent)
        {
            InitializeComponent();
            _parent = parent;
            new ChuNhiemAddPresenter(this);
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            giaoVienSelected = (GiaoVienSearchDto)listBox1.SelectedItem;
            txtTenGiaoVien.Text = giaoVienSelected.HoTen;
        }

        public void ResetForm()
        {
            txtTenGiaoVien.Text = "";
            txtTenLop.Text = "";
            txtNamHoc.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnAdd?.Invoke(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new ChuNhiemIndex(_parent));
        }
    }
}
