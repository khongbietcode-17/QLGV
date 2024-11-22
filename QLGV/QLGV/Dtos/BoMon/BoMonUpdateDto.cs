using QLGV.Models;
using QLGV.Views.BoMon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Dtos.BoMon
{
    public class BoMonUpdateDto
    {
        public string Id { get; set; }
        public string TenBoMon { get; set; }

        public static BoMonUpdateDto FromView(BoMonEdit view)
        {
            return new BoMonUpdateDto
            {
                Id = view.Id,
                TenBoMon = view.TenBoMon,
            };
        }

        public BoMonModel ToModel()
        {
            return new BoMonModel
            {
                BoMonId = int.Parse(Id),
                TenBoMon = TenBoMon,
            };
        }
    }
}
