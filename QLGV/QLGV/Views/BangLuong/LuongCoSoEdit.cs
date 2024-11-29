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
    public partial class LuongCoSoEdit : Form, ILuongCoSoEdit
    {
        public string LuongCoSo { get => txtLuongCoSo.Text; set => txtLuongCoSo.Text = value; }
        public event EventHandler OnUpdate;
        public LuongContainer _parent;
        public LuongCoSoEdit(LuongContainer parent)
        {
            InitializeComponent();
            new LuongCoSoEditPresenter(this);
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new LuongIndex(_parent));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnUpdate?.Invoke(this, EventArgs.Empty);    
        }
    }
}
