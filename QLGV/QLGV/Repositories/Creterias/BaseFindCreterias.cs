using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.Creterias
{
    public class BaseFindCreterias
    {
        public int[] Ids {  get; set; }

        public BaseFindCreterias(int[] Ids)
        {
            this.Ids = Ids;
        }

        public static BaseFindCreterias Empty()
        {
            return new BaseFindCreterias(new int[0]);
        }
    }
}
