using Entities.Concrete;
using Entities.Enums;
using Entities.Exceptions;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository = new UserRepository();

        public void Add(User user)
        {
            if (CheckIfUserExists(user.Email))
                throw new UserAlreadyExistsException(user.Email);


            _userRepository.Create(user);

        }

        public User GetByEmail(string email)
        {
            var user = _userRepository.Get(u => u.Email.Equals(email));

            if (user is null)
                throw new UserNotFoundException(email);

            return user;

        }

        private bool CheckIfUserExists(string email)

            => _userRepository.Any(u => u.Email.Equals(email));


        public void UpdateStatus(int userId, UserStatus status)
        {

            var user = _userRepository.GetById(userId);

            user.UserStatus = status;

            _userRepository.Update(user);
        }

        public void ChangeUserFirstName(int userId, string newFirstname)
        {
           var user = _userRepository.GetById(userId);

            user.FirstName = newFirstname;

            _userRepository.Update(user);
        }

        public void ChangeUserLastName(int userId, string newLastname)
        {
            var user = _userRepository.GetById(userId);

            user.LastName = newLastname;

            _userRepository.Update(user);
        }

        public void ChangeUserAim(int userId, Aim newAim)
        {
            var user = _userRepository.GetById(userId);

            user.Aim = newAim;
            _userRepository.Update(user);
        }

        public void ChangeUserHeight(int userId, double newHeight)
        {
            var user = _userRepository.GetById(userId);

            user.Height = newHeight;
            _userRepository.Update(user);
        }

        public void ChangeUserWeight(int userId, double newWeight)
        {
            var user = _userRepository.GetById(userId);

            user.Weight = newWeight;
            _userRepository.Update(user);
        }

        public string CalculateBmi(int userId, double height, double weight)
        {
            var user = _userRepository.GetById(userId);

            user.Weight = weight;
            user.Height = height;
            double status = (weight /(Math.Pow(height,2)));
            if (status < 18.5)
            {
                return BmiStatus.UnderWeight.ToString();
            }
            else if (status >= 18.5 && status < 25)
            {
                return BmiStatus.NormalWeight.ToString();
            }
            else if (status >= 25 && status < 30)
            {
                return BmiStatus.Overweight.ToString();
            }
            else
            {
                return BmiStatus.Obesity.ToString();
            }

        }
    }
}