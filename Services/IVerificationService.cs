using Entities.Concrete;

namespace Services
{
    public interface IVerificationService
    {
        void BeginVerification(User user);
        bool ConfirmVerification(int userId, string verificationCode);
    }
}
