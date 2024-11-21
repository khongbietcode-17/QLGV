using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    public class PhanCongRepository : BaseRepository<PhanCongModel>, IPhanCongRepository
    {
        public override string TableName => "PhanCong";
        public override string PrimaryKey => "GiaoVienId";

        public override string[] ColumnList => new string[]
        {
            "GiaoVienId",
            "ChucVuId",
        };

        public override string[] ColumnListAdd => new string[]
        {
            "GiaoVienId",
            "ChucVuId",
        };

        public override void AddParameter(ref SqlCommand cmd, PhanCongModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@GiaoVienId", SqlDbType.Int)).Value = model.GiaoVienId;
            cmd.Parameters.Add(new SqlParameter("@ChucVuId", SqlDbType.Int)).Value = model.ChucVuId;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
