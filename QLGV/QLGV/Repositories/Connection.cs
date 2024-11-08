using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repository
{
    internal class Connection
    {
      private static string _connString;
      public static SqlConnection CreateConnection()
        {
            if(_connString == null)
            {
            _connString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;
            }
            return new SqlConnection(_connString);
        }       
    }
    
}
