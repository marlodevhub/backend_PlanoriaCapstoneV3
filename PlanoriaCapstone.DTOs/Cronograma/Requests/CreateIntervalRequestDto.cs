
namespace PlanoriaCapstone.DTOs.Cronograma.Requests
{
    public class CreateIntervalRequestDto
    {
        public string IntervalType { get; set; }
        public int DurationMinutes { get; set; }
        public int OrderPosition { get; set; }
    }
}
