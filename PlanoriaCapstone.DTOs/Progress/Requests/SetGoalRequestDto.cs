
namespace PlanoriaCapstone.DTOs.Progress.Requests
{
    public class SetGoalRequestDto
    {
        public int CourseId { get; set; }
        public string TargetType { get; set; }
        public int TargetValue { get; set; }
        public DateTime Deadline { get; set; }
        public string Metric { get; set; }
    }
}
