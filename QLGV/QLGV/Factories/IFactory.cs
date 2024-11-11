using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Factories
{
    internal interface IFactory<T>
    {
        T GetInstance(string name); 
    }
}
