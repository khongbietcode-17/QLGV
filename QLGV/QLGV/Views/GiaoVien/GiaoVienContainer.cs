﻿using System;
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
            SetChildren(new GiaoVienIndex(this));
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
            switch(name)
            {
                case "GiaoVienIndex":
                    label = "Danh sách";
                    break;
                case "GiaoVienAdd":
                    label = "Thêm giáo viên";
                    break;
                case "GiaoVienEdit":
                    label = "Chỉnh sửa";
                    break;
            } 
            label3.Text = label;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SetChildren(new GiaoVienIndex(this));
        }
    }
}
