using Entities.Concrete;

namespace Services.Abstract
{
    public interface IUserService
    {
        User GetByEmail(string email);

        void Add(User user);
    }
}