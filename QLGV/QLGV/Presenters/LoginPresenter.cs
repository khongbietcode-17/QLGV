using QLGV.Dtos;
using QLGV.Services;
using QLGV.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Presenters
{
    public class LoginPresenter
    {
        private readonly LoginForm _view;
        private readonly UserService _service;
        public LoginPresenter(LoginForm view) 
        {
            _view = view;
            _service = new UserService();
            _view.OnLogin += HandleLogin;
        }

        private void HandleLogin(object sender, EventArgs args)
        {
            LoginDto dto = LoginDto.FromView(_view);

            if(!_service.Validate(dto))
            {
                return;
            }

            if(!_service.Login(dto))
            {
                _view.Message = "Username hoặc mật khẩu sai";
                return;
            };
            _view.UserInfo = dto.UserName;
            _view.AuthenticatedSuccess = true;
            _view.Close();
        }
    }
}
