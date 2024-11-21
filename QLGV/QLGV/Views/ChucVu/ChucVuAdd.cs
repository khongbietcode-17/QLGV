using System;
using QLGV.Presenters.ChucVu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.ChucVu
{
    public partial class ChucVuAdd : Form
    {
        public event EventHandler Add;
        private readonly ChucVuContainer _parentView;

        public string TenChucVu { get => txtTenChucVu.Text; }
        public ChucVuAdd(ChucVuContainer parentView)
        {
            InitializeComponent();
            new ChucVuAddPresenter(this);
            _parentView = parentView;
            InitEvents();
        }

        private void InitEvents()
        {
            btnAdd.Click += (o, e) => { Add?.Invoke(this, EventArgs.Empty); };
            txtTenChucVu.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Add?.Invoke(this, EventArgs.Empty);
                }
            };
        }
        public void ResetForm()
        {
            txtTenChucVu.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new ChucVuIndex(_parentView));
        }
    }
}
