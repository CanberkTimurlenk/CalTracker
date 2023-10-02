using Entities.Concrete;
using Entities.Enums;

namespace Services.Abstract
{
    public interface IUserService
    {
        User GetByEmail(string email);
        void Add(User user);
        void UpdateStatus(int userId, UserStatus status);
        int RecomendedCalorie(int userId, double weight, ActivitiyStatus activity);
        string CalculateBmi(int userId, double height, double weight);
        void UpdateFirstnameByUserId(int userId, string newFirstname);
        void UpdateLastnameByUserId(int userId, string newLastname);
        void UpdateUserAimByUserId(int userId, int aimId);
        void UpdateAimByUserId(int userId, double newHeight);
        void UpdateWeightByUserId(int userId, double newWeight);

    }
}