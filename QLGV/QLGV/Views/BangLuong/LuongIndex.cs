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
        private readonly LuongContainer _parent;
        public event EventHandler OnSearch; 
        public string SearchKey { get => textBox1.Text; }
        public string LuongCoSo { get => label2.Text; set => label2.Text = value; }

        public LuongIndex(LuongContainer parent)
        {
            InitializeComponent();
            _parent = parent;
            new LuongIndexPresenter(this); 
            DisableEditBtn();
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
                DisableEditBtn();
            }
            else if (numOfRowSelected == 1)
            {
                EnableEditBtn();
            }
            else
            {
                DisableEditBtn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSearch?.Invoke(this, EventArgs.Empty);
        }
        public int GetSelectedRowId()
        {
            var row = dataGridView1.SelectedRows;
            return int.Parse(row[0].Cells[0].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new LuongEdit(GetSelectedRowId(), _parent));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OnSearch?.Invoke(sender, EventArgs.Empty);
            }
        }

        private void btnEditLuongCS_Click(object sender, EventArgs e)
        {
            _parent.SetChildren(new LuongCoSoEdit(_parent));
        }
    }
}
