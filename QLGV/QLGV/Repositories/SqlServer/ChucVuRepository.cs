using QLGV.Models;
using System.Data;
using System.Data.SqlClient;


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
                "ChucVuId",
                "TenChucVu"
            };
        }

        public override string[] ColumnListAdd => new string[]
        {
            "TenChucVu"
        };

        public override void AddParameter(ref SqlCommand cmd, ChucVuModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@TenChucVu", SqlDbType.NVarChar)).Value = model.TenChucVu;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new ChucVuModel()
            {
                ChucVuId = reader.GetInt32(offset++),
                TenChucVu = reader.GetString(offset),
            };
        }
    }
}
