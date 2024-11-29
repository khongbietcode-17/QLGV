using QLGV.Models;
using QLGV.Presenters.Luong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.BangLuong
{
    public partial class LuongEdit : Form, ILuongEdit
    {
        private LuongContainer _parent;
        public event EventHandler OnUpdate;
        public int InitId { get; set; }
        public string HeSoLuong { get => txtHeSoLuong.Text; set => txtHeSoLuong.Text = value; }
        public string HeSoPhuCap { get => txtHeSoPhuCap.Text; set => txtHeSoPhuCap.Text = value; }
        public LuongEdit(int initId, LuongContainer parent)
        {
            InitializeComponent();
            _parent = parent;   
            InitId = initId;
            new LuongEditPresenter(this);
        }

        public void InitData(BangLuongModel model)
        {
            txtTenGiaoVien.Text = model.GiaoVien.HoLot + " " + model.GiaoVien.Ten;
            txtHeSoLuong.Text = model.HeSoLuong.ToString();
            txtHeSoPhuCap.Text = model.HeSoPhuCap.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new LuongIndex(_parent));
        }
    }
}
