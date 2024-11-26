using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views.ChuNhiem
{
    public partial class ChuNhiemContainer : Form
    {
        Form childrenView;
        public ChuNhiemContainer()
        {
            InitializeComponent();
            SetChildren(new ChuNhiemIndex(this));
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
                case "ChuNhiemIndex":
                    label = "Danh sách";
                    break;
                case "ChuNhiemAdd":
                    label = "Thêm";
                    break;
                case "ChuNhiemEdit":
                    label = "Chỉnh sửa";
                    break;
            }
            label3.Text = label;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetChildren(new ChuNhiemIndex(this));
        }
    }
}
