using QLGV.Dtos.Luong;
using QLGV.Models;
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
    public partial class LuongIndex : Form
    {
        public LuongIndex()
        {
            InitializeComponent();
            new LuongIndexPresenter(this); 
            DisableEditBtn();
            DisableViewBtn();
            DisableDeleteBtn();
        }

        public void LoadData(IEnumerable<LuongTableDto> bangLuong)
        {
            dataGridView1.Rows.Clear();
            foreach (LuongTableDto luong in bangLuong)
            {
                dataGridView1.Rows.Add(
                    luong.Id,
                    luong.TenGiaoVien,
                    luong.HeSoLuong,
                    luong.HeSoPhuCap,
                    luong.Luong
                );
            }
        }

        public DataGridViewSelectedRowCollection GetSelectedRow()
        {
            return dataGridView1.SelectedRows;
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    _parentView.SetChildren(new GiaoVienAdd(_parentView));
        //}

        public void clearSelection()
        {
            dataGridView1.ClearSelection();
        }

        private void DisableDeleteBtn()
        {
            btnDelete.Enabled = false;
            btnDelete.BackColor = Color.FromArgb(40, 247, 56, 56);
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
            if (numOfRowSelected > 1)
            {
                EnableDeleteBtn();
                DisableEditBtn();
                DisableViewBtn();
            }
            else if (numOfRowSelected == 1)
            {
                EnableDeleteBtn();
                EnableEditBtn();
                EnableViewBtn();
            }
            else
            {
                DisableViewBtn();
                DisableEditBtn();
                DisableDeleteBtn();
            }
        }
    }
}
