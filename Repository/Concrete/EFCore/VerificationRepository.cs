using Entities.Concrete;
using Repository.Abstract;
using Repository.Abstract.Base;

namespace Repository.Concrete.EFCore
{
    public class VerificationRepository : BaseRepository<UserVerification>, IVerificationRepository
    {

    }
}
