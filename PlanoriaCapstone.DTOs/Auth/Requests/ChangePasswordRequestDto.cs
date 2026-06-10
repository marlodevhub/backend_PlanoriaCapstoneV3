namespace PlanoriaCapstone.DTOs.Auth.Requests
{
    public class ChangePasswordRequestDto
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirmation { get; set; }
    }
}
