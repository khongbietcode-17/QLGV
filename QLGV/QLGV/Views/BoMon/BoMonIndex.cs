using QLGV.Dtos.BoMon;
using QLGV.Dtos.ChucVu;
using QLGV.Presenters.BoMon;
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
    public partial class BoMonIndex : Form
    {
        private readonly BoMonContainer _parentView;
        public event EventHandler OnDelete;
        public BoMonIndex(BoMonContainer parentView)
        {
            InitializeComponent();
            _parentView = parentView;
            new BoMonIndexPresenter(this);
            DisableDeleteBtn();
            DisableEditBtn();
        }

        public void LoadData(IEnumerable<BoMonTableDto> list)
        {
            dataGridView1.Rows.Clear();
            foreach (BoMonTableDto item in list)
            {
                dataGridView1.Rows.Add(
                   item.Id,
                   item.TenBoMon
                );
            }
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
        public int GetSelectedRowId()
        {
            var row = dataGridView1.SelectedRows;
            return int.Parse(row[0].Cells[0].Value.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new BoMonAdd(_parentView));
        }
        public DataGridViewSelectedRowCollection GetSelectedRow()
        {
            return dataGridView1.SelectedRows;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new BoMonEdit(GetSelectedRowId(), _parentView));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDelete?.Invoke(sender, EventArgs.Empty);
        }
    }
}
