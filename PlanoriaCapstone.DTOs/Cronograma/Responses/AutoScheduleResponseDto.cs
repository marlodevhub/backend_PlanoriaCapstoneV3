
namespace PlanoriaCapstone.DTOs.Cronograma.Responses
{
    public class AutoScheduleResponseDto
    {
        public List<ScheduleResponseDto> GeneratedSchedules { get; set; }
        public decimal TotalHours { get; set; }
        public List<string> RecommendedAdjustments { get; set; }
        public List<string> Conflicts { get; set; }
    }
}
