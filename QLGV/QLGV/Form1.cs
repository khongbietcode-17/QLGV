using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV
{
    public partial class Form1 : Form
    {
        formGiaovien giaovien;
        formLuong luong;
        formChucvu chucvu;

        public Form1()
        {
            InitializeComponent();
        }

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand) {
                menu.Width -= 10;
                if (menu.Width <= 40) {
                    menuExpand = false;
                    menuTransition.Stop();

                    pnGiaovien.Width = menu.Width;
                    pnLuong.Width = menu.Width;
                    pnChucvu.Width = menu.Width;

                }
            } else { 
            menu.Width += 10;
                if (menu.Width >= 170) { 
                menuExpand= true;
                menuTransition.Stop();

                pnGiaovien.Width = menu.Width;
                pnLuong.Width = menu.Width;
                pnChucvu.Width = menu.Width;

                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            if (giaovien == null)
            {
                giaovien = new formGiaovien();
                giaovien.FormClosed += Giaovien_FormClosed;
                giaovien.MdiParent = this;
                giaovien.Show();
            }
            else { 
            giaovien.Activate();
            }
        }

        private void Giaovien_FormClosed(object sender, FormClosedEventArgs e)
        {
            giaovien = null;
        }

        private void btnChucvu_Click(object sender, EventArgs e)
        {
            if (chucvu == null)
            {
                chucvu = new formChucvu();
                chucvu.FormClosed += Chucvu_FormClosed;
                chucvu.MdiParent = this;
                chucvu.Dock = DockStyle.Fill;
                chucvu.Show();
            }
            else
            {
                chucvu.Activate();
            }
        }

        private void Chucvu_FormClosed(object sender, FormClosedEventArgs e)
        {
            chucvu = null;
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            if (luong == null)
            {
                luong = new formLuong();
                luong.FormClosed += Luong_FormClosed;
                luong.MdiParent = this;
                luong.Dock = DockStyle.Fill;
                luong.Show();
            }
            else
            {
                luong.Activate();
            }
        }

        private void Luong_FormClosed(object sender, FormClosedEventArgs e)
        {
            luong = null;
        }
    }
}
