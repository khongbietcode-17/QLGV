using QLGV.Models;
using System;
using System.Data;
using System.Data.SqlClient;


namespace QLGV.Repositories.SqlServer
{
    internal class BoMonRepository: BaseRepository<BoMonModel>, IBoMonRepository
    {
        public override string[] ColumnList
        {
            get => new string[]
            {
                "BoMonId",
                "TenBoMon",
            };
        }

        public override string TableName
        {
            get => "BoMon";
        }

        public override string[] ColumnListAdd => new string[]
        {
            "TenBoMon",
        };

        public override void AddParameter(ref SqlCommand cmd, BoMonModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@BoMonId", SqlDbType.Int)).Value = model.BoMonId;
            cmd.Parameters.Add(new SqlParameter("@TenBoMon", SqlDbType.NVarChar)).Value = model.TenBoMon;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new BoMonModel()
            {
                BoMonId = reader.GetInt32(offset++),
                TenBoMon = reader.GetString(offset),
            };
        }
    }
}
