﻿using QLGV.Models;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            throw new NotImplementedException();
        }
    }
}
