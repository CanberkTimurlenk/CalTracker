using Entities.Concrete;
using Entities.Dtos;
using Entities.Exceptions;

namespace Services
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService = new UserManager();
        public User Login(UserForLoginDto userForLogin)
        {
            var user = _userService.GetByEmail(userForLogin.Email);

            if (!user.Password.Equals(userForLogin.Password))
                throw new WrongCredentialsException(userForLogin.Email);

            return user;
        }

        public User Register(UserForRegisterDto userForRegister)
        {
            _userService.Add(user);

            return null;
        }


    }
}