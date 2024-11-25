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
    public class LuongCoSoRepository : BaseRepository<LuongCoSoModel>, ILuongCoSoRepository
    {
        public override string TableName => "LuongCoSo";

        public override string[] ColumnList => new string[]
        {
            "LuongCoSoId",
            "LuongCoSo",
            "UpdateAt"
        };

        public override string[] ColumnListAdd => new string[]
        {
            "LuongCoSo",
            "UpdateAt"
        };

        public override void AddParameter(ref SqlCommand cmd, LuongCoSoModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@LuongCoSoId", SqlDbType.Int)).Value = model.LuongCoSoId;
            cmd.Parameters.Add(new SqlParameter("@LuongCoSo", SqlDbType.Int)).Value = model.LuongCoSo;
            cmd.Parameters.Add(new SqlParameter("@UpdateAt", SqlDbType.DateTime)).Value = model.UpdateAt;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new LuongCoSoModel
            {
                LuongCoSoId = reader.GetInt32(offset++),
                LuongCoSo = reader.GetInt32(offset++),
                UpdateAt = reader.GetDateTime(offset),
            };
        }
    }
}
