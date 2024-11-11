using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    internal class BoMonRepository: BaseRepository<BoMonModel>
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

        public override BoMonModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new BoMonModel()
            {
                BoMonId = reader.GetInt32(offset++),
                TenBoMon = reader.GetString(offset),
            };
        }
    }
}
