
namespace PlanoriaCapstone.DTOs.Progress.Requests
{
    public class UpdateGoalProgressRequestDto
    {
        public int GoalId { get; set; }
        public int CurrentValue { get; set; }
        public string Status { get; set; }
    }
}
