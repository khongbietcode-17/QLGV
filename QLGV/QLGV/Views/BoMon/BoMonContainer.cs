using QLGV.Views.GiaoVien;
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
    public partial class BoMonContainer : Form
    {
        Form childrenView;
        public BoMonContainer()
        {
            InitializeComponent();
            SetChildren(new BoMonIndex(this));
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
                case "BoMonIndex":
                    label = "Danh sách";
                    break;
                case "BoMonAdd":
                    label = "Thêm bộ môn";
                    break;
                case "BoMonEdit":
                    label = "Chỉnh sửa";
                    break;
            }
            label3.Text = label;
        }
    }
}
