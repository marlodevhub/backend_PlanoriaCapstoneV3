
namespace PlanoriaCapstone.DTOs.Auth.Requests
{
    public class ResetPasswordRequestDto
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
