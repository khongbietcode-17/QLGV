using QLGV.Dtos.ChuNhiem;
using QLGV.Presenters.ChuNhiem;
using QLGV.Views.GiaoVien;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace QLGV.Views.ChuNhiem
{
    public partial class ChuNhiemIndex : Form
    {
        
        public ChuNhiemIndex()
        {
            InitializeComponent();
            new ChuNhiemIndexPresenter(this);
            DisableEditBtn();
            DisableViewBtn();
            DisableDeleteBtn();
        }

        public void LoadData(IEnumerable<ChuNhiemTableDto> chuNhiems)
        {
            dataGridView1.Rows.Clear();
            foreach (ChuNhiemTableDto chuNhiem in chuNhiems)
            {
                dataGridView1.Rows.Add(
                    chuNhiem.Id,
                    chuNhiem.TenGiaoVien,
                    chuNhiem.TenLop,
                    chuNhiem.NamHoc
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
