using Entities.Concrete;

namespace Services
{
    public interface IUserService
    {
        User GetByEmail(string email);

        void Add(User user);
    }
}