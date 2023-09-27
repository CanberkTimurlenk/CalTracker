using Entities.Concrete;
using Repository.Abstract.Base;
using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete.EFCore
{
    public class UserDataRepository : BaseRepository<UserData>, IUserDataRepository
    {
    }
}
