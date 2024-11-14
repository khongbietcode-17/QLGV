using QLGV.Repositories.SqlServer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Factories
{
    public class RepositoryFactory: IFactory<IRepository>
    {
        public IRepository GetInstance(string modelName)
        {
            switch (modelName)
            {
                case "GiaoVienModel":
                    return new GiaoVienRepository();
                case "BoMonModel":
                    return new BoMonRepository();
                case "ChucVuModel":
                    return new ChucVuRepository();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
