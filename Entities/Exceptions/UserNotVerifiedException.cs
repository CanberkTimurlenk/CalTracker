namespace Services
{

    public class UserNotVerifiedException : Exception
    {

        public UserNotVerifiedException(string email, int userId) : base($"Verification was not completed for: {email}\nPlease Complete The Verification.")
        {
            UserId = userId;
        }
        public int UserId { get; set; }

    }
}