using PlanoriaCapstone.DTOs.Users.Responses;

namespace PlanoriaCapstone.DTOs.Courses.Responses
{
    public class CourseMemberResponseDto
    {
        public int Id { get; set; }
        public UserResponseDto User { get; set; }
        public string Role { get; set; }
        public DateTime JoinedAt { get; set; }
    }
}
