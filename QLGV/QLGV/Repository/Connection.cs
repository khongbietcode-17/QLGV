using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repository
{
    internal class Connection
    {
      public static SqlConnection CreateConnection()
        {

        return new SqlConnection();
        }       
    }
    
}
