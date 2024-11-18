using QLGV.Dtos.ChucVu;
using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.BoMon
{
    public class BoMonTableDto
    {
        public string Id { get; set; }
        public string TenBoMon { get; set; }

        public static BoMonTableDto FromModel(BoMonModel model)
        {
            return new BoMonTableDto()
            {
                Id = model.BoMonId.ToString(),
                TenBoMon = model.TenBoMon,
            };
        }
    }
}
