using QLGV.Views.GiaoVien;
using QLGV.Views.ChucVu;
using QLGV.Views.Luong;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Factories
{
    public class DashBoardChildrenFactory: IFormFactory
    {
        public Form GetForm(string formName)
        {
            switch (formName) 
            {
                case "giaovien":
                    return new GiaoVienContainer();
                case "chucvu":
                    return new ChucVuContainer();
                case "luong":
                    return new LuongContainer();
                default:
                    throw new ArgumentOutOfRangeException();
                    
            }
        }
    }
}
