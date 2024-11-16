using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.Luong
{
    public partial class LuongContainer : Form
    {
        Form childrenView;
        public LuongContainer()
        {
            InitializeComponent();
            SetChildren(new LuongIndex());
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
            ChangeLabel(childrenView.GetType().Name);
            childrenView.Show();
        }

        public void ChangeLabel(string name)
        {
            string label = "";
            switch (name)
            {
                case "LuongIndex":
                    label = "Danh sách";
                    break;
                case "LuongAdd":
                    label = "Thêm";
                    break;
                case "LuongEdit":
                    label = "Chỉnh sửa";
                    break;
            }
            label3.Text = label;
        }
    }
}
