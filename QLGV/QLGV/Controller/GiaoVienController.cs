using QLGV.View.GiaoVien;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Controller
{
    internal class GiaoVienController
    {
        private DataSet _giaoVienDataSet;

        public Form Index()
        {
            return new GiaoVienIndexForm();
        }
    }
}
