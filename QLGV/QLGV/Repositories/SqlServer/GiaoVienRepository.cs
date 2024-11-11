using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Repositories.SqlServer
{
    internal class GiaoVienRepository: BaseRepository<GiaoVienModel>, IGiaoVienRepository
    {
        public override string TableName
        {
            get => "GiaoVien";
        }

        public override string[] ColumnList
        {
            get => new string[] { 
                "GiaoVienId",
                "HoLot",
                "Ten",
                "GioiTinh",
                "NgaySinh",
                "DiaChi",
                "Email",
                "SoDienThoai",
                "BoMonId",
            };
        }

        public override GiaoVienModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new GiaoVienModel()
            {
                GiaoVienId = reader.GetInt32(offset++),
                HoLot = reader.GetString(offset++),
                Ten = reader.GetString(offset++),
                GioiTinh = reader.GetByte(offset++),
                NgaySinh = reader.GetDateTime(offset++),
                DiaChi = reader.GetString(offset++),  
                Email = reader.GetString(offset++),
                SoDienThoai = reader.GetString(offset++),
                BoMonId = reader.GetInt32(offset),
            };
        }

        public IEnumerable<GiaoVienModel> FindIncludeBoMon(BaseFindCreterias creterias)
        {
            return FindIncludeOne<BoMonModel>(creterias, new BoMonRepository());
        }
    }
}
