using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QLGV.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    public interface IRepository
    {
        string TableName { get; }

        string AllColumnString {  get; }

        string PrimaryKey {  get; }

        BaseModel ReaderMapper(SqlDataReader reader, int offset);
    }
}
