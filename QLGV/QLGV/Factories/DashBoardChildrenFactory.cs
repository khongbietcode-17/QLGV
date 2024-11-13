using QLGV.Views.GiaoVien;
using QLGV.Views.ChucVu;
using QLGV.Views.Luong;
using QLGV.Views.BoMon;
using QLGV.Views.ChuNhiem;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Factories
{
    public class DashBoardChildrenFactory: IFactory<Form>
    {
        public Form GetInstance(string formName)
        {
            switch (formName) 
            {
                case "giaovien":
                    return new GiaoVienContainer();
                case "chucvu":
                    return new ChucVuContainer();
                case "luong":
                    return new LuongContainer();
                case "bomon":
                    return new BoMonContainer();
                case "chunhiem":
                    return new ChuNhiemContainer();
                default:
                    throw new ArgumentOutOfRangeException();
                    
            }
        }
    }
}
