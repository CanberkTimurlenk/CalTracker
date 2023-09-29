namespace Entities.Dtos
{
    public record UserVerificationDto
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string VerificationCode { get; set; }
    }
}
