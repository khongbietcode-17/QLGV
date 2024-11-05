using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;

namespace QLGV.Repository
{
    
    internal class Connection
    {
        private const string ConnectionString = "Server=ADMIN-PC;Database=QLGV;User Id=sa;Password=sql2022;";

        private static SqlConnection _connection;

        public static SqlConnection CreateSqlConnection()
        {
            if(_connection == null)
            {
                return _connection;
            }
            _connection = new SqlConnection(ConnectionString);
             return _connection;
        }
    }
}
