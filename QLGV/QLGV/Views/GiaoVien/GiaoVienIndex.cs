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
    public partial class GiaoVienIndex : Form, IGiaoVienIndex
    {
        private IGiaoVienContainer _parentView;
        public GiaoVienIndex(IGiaoVienContainer parentView)
        {
            InitializeComponent();
            new GiaoVienIndexPresenter(this);
            _parentView = parentView;
        }

        public void LoadData(IEnumerable<GiaoVienTableDto> giaoViens)
        {
            foreach(GiaoVienTableDto giaoVien in giaoViens)
            {
                dataGridView1.Rows.Add(
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

        private void button1_Click(object sender, EventArgs e)
        {
            _parentView.SetChildren(new GiaoVienAdd());
        }

  
    }
}
