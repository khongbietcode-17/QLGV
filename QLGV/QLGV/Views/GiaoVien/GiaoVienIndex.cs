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
    public partial class GiaoVienIndex : Form
    {
        private IGiaoVienContainer _parentView;
        public GiaoVienIndex(IGiaoVienContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new GiaoVienAdd());
        }
    }
}
