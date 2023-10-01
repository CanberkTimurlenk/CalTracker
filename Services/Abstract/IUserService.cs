using Entities.Concrete;
using Entities.Enums;

namespace Services.Abstract
{
    public interface IUserService
    {
        User GetByEmail(string email);
        void Add(User user);
        void UpdateStatus(int userId, UserStatus status);

        string CalculateBmi(int userId, double height, double weight);
        void ChangeUserFirstName(int userId, string newFirstname);
        void ChangeUserLastName(int userId, string newLastname);
        void ChangeUserAim(int userId, Aim newAim);
        void ChangeUserHeight(int userId, double newHeight);
        void ChangeUserWeight(int userId, double newWeight);

    }
}