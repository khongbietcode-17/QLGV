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
        private ChuNhiemContainer _parent;
        public event EventHandler OnDelete;
        
        public ChuNhiemIndex(ChuNhiemContainer parent)
        {
            InitializeComponent();
            _parent = parent;   
            new ChuNhiemIndexPresenter(this);
            DisableEditBtn();
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
      
        public int GetSelectedRowId()
        {
            var row = dataGridView1.SelectedRows;
            return int.Parse(row[0].Cells[0].Value.ToString());
        }

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int numOfRowSelected = dataGridView1.SelectedRows.Count;
            if (numOfRowSelected > 1)
            {
                EnableDeleteBtn();
                DisableEditBtn();
            }
            else if (numOfRowSelected == 1)
            {
                EnableDeleteBtn();
                EnableEditBtn();
            }
            else
            {
                DisableEditBtn();
                DisableDeleteBtn();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new ChuNhiemAdd(_parent));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new ChuNhiemEdit(GetSelectedRowId(), _parent));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(this, EventArgs.Empty);
        }
    }
}
