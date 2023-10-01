using Entities.Concrete;
using Repository.Abstract.Base;

namespace Repository.Abstract
{
    public interface IUserRepository : IBaseRepository<User>
    {
        int GetActiveUserCount();

    }
}