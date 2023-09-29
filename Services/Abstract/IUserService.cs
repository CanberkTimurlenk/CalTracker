using Entities.Concrete;
using Entities.Enums;

namespace Services.Abstract
{
    public interface IUserService
    {
        User GetByEmail(string email);
        void Add(User user);
        void UpdateStatus(int userId, UserStatus status);
    }
}