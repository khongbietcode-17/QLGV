using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    public class ChucVuRepository: BaseRepository<ChucVuModel>
    {
        public override string TableName
        {
            get => "ChucVu";
        }

        public override string[] ColumnList
        {
            get => new string[] {
                "GiaoVienId",
                "TenChucVu"
            };
        }

        public override ChucVuModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new ChucVuModel()
            {
                ChucVuId = reader.GetInt32(offset++),
                TenChucVu = reader.GetString(offset),
            };
        }
    }
}
