using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Repositories.Creterias
{
    public class BaseFindCreterias
    {
        public int[] Ids {  get; set; }

        public List<(string, string)> Column { get; set; }

        public BaseFindCreterias(int[] Ids)
        {
            this.Ids = Ids;
        }

        public BaseFindCreterias()
        {
            Column = new List<(string, string)>();
        }

        public static BaseFindCreterias Empty()
        {
            return new BaseFindCreterias(new int[0]);
        }
    }
}
