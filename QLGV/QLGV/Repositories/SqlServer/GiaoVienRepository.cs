using QLGV.Models;
using QLGV.Repositories.Creterias;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace QLGV.Repositories.SqlServer
{
    internal class GiaoVienRepository: BaseRepository<GiaoVienModel>, IGiaoVienRepository
    {
        public override string TableName => "GiaoVien";

        public override string[] ColumnList => new string[] { 
            "GiaoVienId",
            "HoLot",
            "Ten",
            "GioiTinh",
            "NgaySinh",
            "DiaChi",
            "Email",
            "SoDienThoai",
            "BoMonId",
        };

        public override string[] ColumnListAdd => new string[]
        {
            "HoLot",
            "Ten",
            "GioiTinh",
            "NgaySinh",
            "DiaChi",
            "Email",
            "SoDienThoai",
            "BoMonId",
        };

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new GiaoVienModel()
            {
                GiaoVienId = reader.GetInt32(offset++),
                HoLot = reader.GetString(offset++),
                Ten = reader.GetString(offset++),
                GioiTinh = reader.GetByte(offset++),
                NgaySinh = reader.GetDateTime(offset++),
                DiaChi = reader.GetString(offset++),  
                Email = reader.GetString(offset++),
                SoDienThoai = reader.GetString(offset++),
                BoMonId = reader.GetInt32(offset),
            };
        }

        public override void AddParameter(ref SqlCommand cmd, GiaoVienModel model)
        {
            cmd.Parameters.Add(new SqlParameter("@HoLot", SqlDbType.NVarChar)).Value = model.HoLot;
            cmd.Parameters.Add(new SqlParameter("@Ten", SqlDbType.NVarChar)).Value = model.Ten;
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.TinyInt)).Value = model.GioiTinh;
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.DateTime)).Value = model.NgaySinh;
            cmd.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar)).Value = model.DiaChi;
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar)).Value = model.Email;
            cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.NVarChar)).Value = model.SoDienThoai;
            cmd.Parameters.Add(new SqlParameter("@BoMonId", SqlDbType.Int)).Value = model.BoMonId;
        }

        public IEnumerable<GiaoVienModel> FindIncludeBoMon(BaseFindCreterias creterias)
        {
            //var test = FindIncludeMany<ChucVuModel>(creterias, "GiaoVienChucVu");
            return FindIncludeOne<BoMonModel>(creterias);
        }

        
    }
}
