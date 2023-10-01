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

    }
}