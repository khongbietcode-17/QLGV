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
    public partial class GiaoVienContainer : Form
    {
        Form childrenView;
        public GiaoVienContainer()
        {
            InitializeComponent();
            SetChildren(new GiaoVienIndex());
        }

        public void SetChildren(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if (childrenView != null)
            {
                childrenView.Close();
            }
            childrenView = form;
            centerPanel.Controls.Add(childrenView);
            childrenView.Show();
        }
    }
}
