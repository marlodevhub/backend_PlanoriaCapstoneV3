using PlanoriaCapstone.DTOs.Users.Responses;

namespace PlanoriaCapstone.DTOs.System.Responses
{
    public class UserActivityLogResponseDto
    {
        public UserResponseDto User { get; set; }
        public string Action { get; set; }
        public string EntityType { get; set; }
        public int? EntityId { get; set; }
        public string Details { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
