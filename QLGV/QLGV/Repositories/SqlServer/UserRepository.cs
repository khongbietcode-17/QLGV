using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public override string TableName => "UserTbl";

        public override string[] ColumnList => new string[]
        {
            "UserId",
            "UserName",
            "Password"
        };

        public override string[] ColumnListAdd => throw new NotImplementedException();

        public override void AddParameter(ref SqlCommand cmd, UserModel model)
        {
            throw new NotImplementedException();
        }

        public override BaseModel ReaderMapper(SqlDataReader reader, int offset)
        {
            return new UserModel()
            {
                UserId = reader.GetInt32(offset++),
                UserName = reader.GetString(offset++),
                Password = reader.GetString(offset),
            };
        }
    }
}
