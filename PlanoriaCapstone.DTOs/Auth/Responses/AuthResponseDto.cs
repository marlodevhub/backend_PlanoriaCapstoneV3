using PlanoriaCapstone.DTOs.Users.Responses;

namespace PlanoriaCapstone.DTOs.Auth.Responses
{
    public class AuthResponseDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string TokenType { get; set; } = "Bearer";
        public int ExpiresIn { get; set; }
        public UserResponseDto User { get; set; }
    }
}
