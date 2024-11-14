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
    public class BangLuongRepository: BaseRepository<BangLuongModel>
    {
        public override string[] ColumnList => new string[]
        {
                "GiaoVienId",
                "HeSoLuong",
                "HeSoPhuCap",
                "Luong"
        };

        public override string PrimaryKey => "GiaoVienId";

        public override string TableName => "BangLuong";

        protected override bool IsAutoIncreasementKey => false;

        public override void AddParameter(ref SqlCommand cmd, BangLuongModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@GiaoVienId", SqlDbType.Int)).Value = model.GiaoVienId;
            cmd.Parameters.Add(new SqlParameter("@HeSoLuong", SqlDbType.Float)).Value = model.HeSoLuong;
            cmd.Parameters.Add(new SqlParameter("@HeSoPhuCap", SqlDbType.Float)).Value = model.HeSoPhuCap;
            cmd.Parameters.Add(new SqlParameter("@Luong", SqlDbType.Int)).Value = model.Luong;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new BangLuongModel()
            {
                GiaoVienId = reader.GetInt32(offset++),
                HeSoLuong = reader.GetDecimal(offset++),
                HeSoPhuCap = reader.GetDecimal(offset++),
                Luong = reader.GetInt32(offset)
            };
        }
    }
}
