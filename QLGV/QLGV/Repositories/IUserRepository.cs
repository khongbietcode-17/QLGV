using QLGV.Models;

namespace QLGV.Repositories
{
    public interface IUserRepository
    {
        UserModel FindFirst(string column, string value);
    }
}
