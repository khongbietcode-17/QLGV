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
    public class BangLuongRepository: BaseRepository<BangLuongModel>, IBangLuongRepository
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

        public override string[] ColumnListAdd => new string[]
        {
            "GiaoVienId",
            "HeSoLuong",
            "HeSoPhuCap",
            "Luong"
        };


        public override void AddParameter(ref SqlCommand cmd, BangLuongModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@GiaoVienId", SqlDbType.Int)).Value = model.GiaoVienId;
            cmd.Parameters.Add(new SqlParameter("@HeSoLuong", SqlDbType.Float)).Value = model.HeSoLuong;
            cmd.Parameters.Add(new SqlParameter("@HeSoPhuCap", SqlDbType.Float)).Value = model.HeSoPhuCap;
            cmd.Parameters.Add(new SqlParameter("@Luong", SqlDbType.Int)).Value = model.Luong;
        }

        public IEnumerable<BangLuongModel> IncludeGiaoVien(IEnumerable<BangLuongModel> bangLuongs)
        {
            return IncludeOne<GiaoVienModel>(bangLuongs, bangLuongs.Select(item => item.GiaoVienId).ToArray());
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

        public BangLuongModel AddEmpty(int id)
        {
            BangLuongModel model = new BangLuongModel
            {
                GiaoVienId = id,
                HeSoLuong = 0,
                HeSoPhuCap = 0,
                Luong = 0
            };
            Add(model);
            return model;
        }

        public BangLuongModel IncludeGiaoVien(BangLuongModel bangLuongs)
        {
            return IncludeOne<GiaoVienModel>(bangLuongs, bangLuongs.GiaoVienId);
        }
    }
}
