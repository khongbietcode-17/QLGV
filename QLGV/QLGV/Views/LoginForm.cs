using QLGV.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGV.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        public bool AuthenticatedSuccess { get; set; }
        public string UserInfo { get; set; }
        public string UserName { get => txtUserName.Text; }
        public string Password { get => txtPassword.Text; }
        public string Message { get => lbMessage.Text; set => lbMessage.Text = value; }
        public event EventHandler OnLogin;
        

        public LoginForm()
        {
            InitializeComponent();
            AuthenticatedSuccess = false;
            new LoginPresenter(this);
            InitEvents();
        }

        private void InitEvents()
        {
            txtUserName.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
            };
            txtPassword.KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OnLogin?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnLogin?.Invoke(this, EventArgs.Empty);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            Message = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Message = "";
        }
    }
}
