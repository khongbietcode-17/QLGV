using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.SqlServer
{
    internal class GiaoVienRepository: IGiaoVienRepository
    {
        private const string SELECT = "SELECT ";

        private readonly SqlConnection _connection;

        public GiaoVienRepository()
        {
            _connection = Connection.CreateConnection();
        }
        public IEnumerable<GiaoVien> Find()
        {
            throw new NotImplementedException();
        }
    }
}
