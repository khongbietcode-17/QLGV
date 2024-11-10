using QLGV.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Repositories.SqlServer
{
    internal class GiaoVienRepository: IGiaoVienRepository
    {
        private const string SELECT = "SELECT ";

        private const string FIND_ALL = "GiaoVienId, HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId FROM GiaoVien WHERE (1 = 1)";

        private const string FIND_ALL_WITH_BOMON = "GiaoVienId, HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId, TenBoMon FROM GiaoVien JOIN BoMon ON GiaoVien.BoMonId = BoMon.BoMonId WHERE (1 = 1)";



        public GiaoVienRepository()
        {
        }
        public IEnumerable<GiaoVienModel> Find()
        {
                List<GiaoVienModel> giaoViens = new List<GiaoVienModel>();
            try
            {

                using (SqlConnection conn = Connection.CreateConnection())
                {
                    conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    StringBuilder sql = new StringBuilder(SELECT);
                    // select top
                    sql.Append(FIND_ALL);
                    cmd.CommandText = sql.ToString();


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                giaoViens.Add(new GiaoVienModel()
                                {
                                    GiaoVienId = reader.GetInt32(0),
                                    HoLot = reader.GetString(1),
                                    Ten = reader.GetString(2),
                                    GioiTinh = reader.GetByte(3),
                                    NgaySinh = reader.GetDateTime(4),
                                    DiaChi = reader.GetString(5),
                                    Email = reader.GetString(6),
                                    SoDienThoai = reader.GetString(7),
                                    BoMonId = reader.GetInt32(8),
                                });
                            }
                        }
                    }
                };
                return giaoViens;

            } catch (Exception e) 
            {
                MessageBox.Show("Something wrong in " + nameof(GiaoVienRepository) + ": " + e.ToString());
                return giaoViens;
            }
        }

        public IEnumerable<GiaoVienModel> FindWithBoMon()
        {
            throw new NotImplementedException();
        }
    }
}
