using Entities.Concrete;
using Entities.Dtos;
using Entities.Exceptions;
using Services.Abstract;

namespace Services.Concrete
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
            //_userService.Add(user);

            return null;
        }


    }
}