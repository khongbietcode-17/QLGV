using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGV.Views;

namespace QLGV
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Dashboard());
            LoginForm loginForm = new LoginForm();
            Application.Run(loginForm);
            if(loginForm.AuthenticatedSuccess)
            {
               Application.Run(new Dashboard());
            }
        }
    }
}
