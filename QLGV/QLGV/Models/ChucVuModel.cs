using QLGV.Views.GiaoVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    public class ChucVuModel: BaseModel
    {
        public int ChucVuId { get; set; }
        public string TenChucVu { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ChucVuModel other)
            {
                return ChucVuId == other.ChucVuId && TenChucVu == other.TenChucVu;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = -969263012;
            hashCode = hashCode * -1521134295 + ChucVuId.GetHashCode();
            hashCode = hashCode * -1521134295 + TenChucVu.GetHashCode();
            return hashCode;
        }
    }
}
