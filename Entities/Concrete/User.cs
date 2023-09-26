using Entities.Abstract;

namespace Entities.Concrete
{
    public class User : BaseEntity, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public UserStatus UserStatus { get; set; }

        public UserData UserData { get; set; }
        public UserVerification UserVerification { get; set; }

    }
}