using QLGV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV.Views.GiaoVien;

namespace QLGV.Views
{
    public partial class Dashboard : Form
    {
        
        Form childrenView;
        bool menuExpand = true;

        public Dashboard()
        {
            InitializeComponent();
            new DashBoardPresenter(this);
            SetChildren(new GiaoVienContainer());
        }

        public void SetChildren(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            if(childrenView != null)
            {
                childrenView.Close();
            }
            childrenView = form;
            mainPanel.Controls.Add(childrenView);
            childrenView.Show();
        }

       
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand) {
                menu.Width -= 10;
                if (menu.Width <= 50) {
                    menuExpand = false;
                    menuTransition.Stop();

                    
                    giaovien.Width = menu.Width;
                    luong.Width = menu.Width;
                    chucvu.Width = menu.Width;
                    bomon.Width = menu.Width;
                    chunhiem.Width = menu.Width;                  
                }
            } else { 
            menu.Width += 10;
                if (menu.Width >= 170) { 
                menuExpand= true;
                menuTransition.Stop();

                giaovien.Text = "  GIÁO VIÊN";
                chucvu.Text = "  CHỨC VỤ";
                luong.Text = "  LƯƠNG";
                bomon.Text = "  BỘ MÔN";
                chunhiem.Text = "  CHỦ NHIỆM";
                label1.Text = "Digi Edu";
                giaovien.Width = menu.Width;
                luong.Width = menu.Width;
                chucvu.Width = menu.Width;
                bomon.Width = menu.Width;
                chunhiem.Width = menu.Width;

                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            giaovien.Text = "";
            chucvu.Text = "";
            luong.Text = "";
            bomon.Text = "";
            chunhiem.Text = "";
            label1.Text = "";
            menuTransition.Start();
        }
       
        
        public IEnumerable<Button> getMenuControls()
        {
 
            return menu.Controls.OfType<Button>();
        }

    }
}
