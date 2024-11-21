using QLGV.Presenters.BoMon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.BoMon
{
    public partial class BoMonAdd : Form
    {
        public event EventHandler Add;
        private readonly BoMonContainer _parentView;
        public string TenBoMon { get => txtTenBoMon.Text; }
        public BoMonAdd(BoMonContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            new BoMonAddPresenter(this);
            InitEvents();
        }

        private void InitEvents()
        {
            btnAdd.Click += (o, e) => { Add?.Invoke(this, EventArgs.Empty); };            
            txtTenBoMon.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Add?.Invoke(this, EventArgs.Empty);
                }
            };
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new BoMonIndex(_parentView));
        }

        public void ResetForm()
        {
            txtTenBoMon.Clear();
        }
    }
}
