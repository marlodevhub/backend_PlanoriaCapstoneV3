
namespace PlanoriaCapstone.DTOs.Cronograma.Responses
{
    public class ScheduleRecommendationResponseDto
    {
        public string RecommendedStartTime { get; set; }
        public int RecommendedDuration { get; set; }
        public List<string> SuggestedContent { get; set; }
        public string Priority { get; set; }
        public string Reason { get; set; }
    }
}
