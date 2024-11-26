using QLGV.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;

namespace QLGV.Dtos
{
    public class LoginDto
    {
        public string UserName {  get; set; }
        public string Password { get; set; }

        public static LoginDto FromView(LoginForm form)
        {
            return new LoginDto()
            {
                UserName = form.UserName,
                Password = form.Password
            };
        }
    }
}
