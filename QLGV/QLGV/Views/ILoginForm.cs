using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Views
{
    public interface ILoginForm
    {
        bool AuthenticatedSuccess { get; set; }
        string UserInfo { get; set; }
        string UserName { get; }
        string Password { get; }
        string Message { get; set; }
        event EventHandler OnLogin;
        void Close();
    }
}
