using QLGV.Models;
using QLGV.Dtos;
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
using QLGV.Presenters.GiaoVien;

namespace QLGV.Views.GiaoVien
{
    public partial class GiaoVienIndex : Form
    {
        private GiaoVienContainer _parentView;
        public event EventHandler OnDelete;
        
        public GiaoVienIndex(GiaoVienContainer parentView)
        {
            InitializeComponent();
            new GiaoVienIndexPresenter(this);
            _parentView = parentView;
            btnDelete.Click += (sender, e) => { OnDelete?.Invoke(sender, e) ;};
            DisableDeleteBtn();
            DisableEditBtn();
            DisableViewBtn();
        }

        public void LoadData(IEnumerable<GiaoVienTableDto> giaoViens)
        {
            dataGridView1.Rows.Clear();
            foreach (GiaoVienTableDto giaoVien in giaoViens)
            {
                dataGridView1.Rows.Add(
                    giaoVien.Id,
                    giaoVien.HoLot,
                    giaoVien.Ten,
                    giaoVien.GioiTinh,
                    giaoVien.NgaySinh,
                    giaoVien.DiaChi,
                    giaoVien.Email,
                    giaoVien.SoDienThoai,
                    giaoVien.TenBoMon
                );
            }            
        }

        public DataGridViewSelectedRowCollection getSelectedRow()
        {
            return dataGridView1.SelectedRows;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new GiaoVienAdd(_parentView));
        }

        

        public void clearSelection()
        {
            dataGridView1.ClearSelection();
        }

        private void DisableDeleteBtn()
        {
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.FromArgb(40,247, 56, 56);
        }
        private void EnableDeleteBtn()
        {          
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.FromArgb(247, 56, 56);
        }

        private void DisableEditBtn()
        {
            btnEdit.Enabled = false;
            btnEdit.BackColor = Color.FromArgb(40, 247, 155, 56);
        }
        private void EnableEditBtn()
        {
            btnEdit.Enabled = true;
            btnEdit.BackColor = Color.FromArgb(247, 155, 56);
        }

        private void DisableViewBtn()
        {
            btnView.Enabled = false;
            btnView.BackColor = Color.FromArgb(40, 34, 148, 38);
        }
        private void EnableViewBtn()
        {
            btnView.Enabled = true;
            btnView.BackColor = Color.FromArgb(34, 148, 38);
        }




        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView1.SelectedRows.Count;
            if(numOfRowSelected > 1)
            {
                EnableDeleteBtn();
                DisableEditBtn();
                DisableViewBtn();
            } else if(numOfRowSelected == 1)
            {
                EnableDeleteBtn();
                EnableEditBtn();
                EnableViewBtn();
            } else
            {
                DisableViewBtn();
                DisableEditBtn();
                DisableDeleteBtn();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new GiaoVienEdit(this));
        }
    }
}
