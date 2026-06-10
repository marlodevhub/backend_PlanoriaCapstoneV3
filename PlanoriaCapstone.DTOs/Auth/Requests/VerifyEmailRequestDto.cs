
namespace PlanoriaCapstone.DTOs.Auth.Requests
{
    public class VerifyEmailRequestDto
    {
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
