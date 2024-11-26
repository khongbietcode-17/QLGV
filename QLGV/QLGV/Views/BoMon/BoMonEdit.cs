using QLGV.Models;
using QLGV.Presenters.BoMon;
using System;
using System.Windows.Forms;

namespace QLGV.Views.BoMon
{
    public partial class BoMonEdit : Form
    {
        public event EventHandler OnUpdate;
        public int InitId { get; set; }

        private BoMonContainer _parent;
        
        public BoMonEdit(int initId, BoMonContainer parent)
        {
            InitializeComponent();
            InitId = initId;
            _parent = parent;
            new BoMonEditPresenter(this);
        }
        public string Id { get => InitId.ToString(); }
        public string TenBoMon { get => txtTenBoMon.Text;}
        public void InitData(BoMonModel model)
        {
            txtTenBoMon.Text = model.TenBoMon;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new BoMonIndex(_parent));
        }
    }
}
