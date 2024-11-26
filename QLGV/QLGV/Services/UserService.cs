using QLGV.Dtos;
using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.SqlServer;
using QLGV.Validations;

namespace QLGV.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        private readonly LoginValidation _validation;
        public UserService() 
        {
            _repository = new UserRepository();
            _validation = new LoginValidation();
        }

        public bool Validate(LoginDto loginDto)
        {
           return _validation.Validate(loginDto);
        }
        public bool Login(LoginDto dto)
        {
            UserModel user = _repository.FindFirst("UserName", dto.UserName);
            if (user == null)
            {
                return false;
            }
            if(user.Password == dto.Password) 
            {
                return true;
            }
            return false;
        }
    }
}
