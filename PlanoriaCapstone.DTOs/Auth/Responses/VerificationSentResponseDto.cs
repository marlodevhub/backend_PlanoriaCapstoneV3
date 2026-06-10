namespace PlanoriaCapstone.DTOs.Auth.Responses
{
    public class VerificationSentResponseDto
    {
        public string Message { get; set; }
        public string Email { get; set; }
        public DateTime ResentAt { get; set; }
    }
}
