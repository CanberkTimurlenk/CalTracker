using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete.EFCore
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {



    }
}
