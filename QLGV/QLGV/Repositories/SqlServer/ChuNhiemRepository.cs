﻿using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    public class ChuNhiemRepository : BaseRepository<ChuNhiemModel>
    {
        public override string TableName => "ChuNhiem";

        public override string[] ColumnList => new string[]
        {
            "ChuNhiemId",
            "GiaoVienId",
            "TenLop",
            "NamHoc",
        };

        public override void AddParameter(ref SqlCommand cmd, ChuNhiemModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@GiaoVienId", SqlDbType.Int)).Value = model.GiaoVienId;
            cmd.Parameters.Add(new SqlParameter("@TenLop", SqlDbType.NVarChar)).Value = model.TenLop;
            cmd.Parameters.Add(new SqlParameter("@NamHoc", SqlDbType.NVarChar)).Value = model.NamHoc;
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new ChuNhiemModel()
            {
                ChuNhiemId = reader.GetInt32(offset++),
                GiaoVienId = reader.GetInt32(offset++),
                TenLop = reader.GetString(offset++),
                NamHoc = reader.GetString(offset),
            };
        }
    }
}
