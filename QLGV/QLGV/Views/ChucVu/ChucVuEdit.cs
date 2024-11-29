using QLGV.Models;
using QLGV.Presenters.ChucVu;
using QLGV.Views.ChucVu;
using System;
using System.Windows.Forms;

namespace QLGV.Views.ChucVu
{
    public partial class ChucVuEdit : Form,  IChucVuEdit
    {
        public event EventHandler OnUpdate;
        public int InitId { get; set; }

        private ChucVuContainer _parent;

        public ChucVuEdit(int initId, ChucVuContainer parent)
        {
            InitializeComponent();
            InitId = initId;
            _parent = parent;
            new ChucVuEditPresenter(this);
        }
        public string TenChucVu { get => txtTenChucVu.Text; }
        public void InitData(ChucVuModel model)
        {
            txtTenChucVu.Text = model.TenChucVu;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new ChucVuIndex(_parent));
        }
    }
}
