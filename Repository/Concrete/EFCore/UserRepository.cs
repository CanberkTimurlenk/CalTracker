using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;
using Repository.Context;

namespace Repository.Concrete.EFCore
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public int GetActiveUserCount()
        {
            using var context = new KaloriTakipDbContext();

            return context.Users.Count(u => u.UserStatus == Entities.Enums.UserStatus.Active);

        }
    }
}
