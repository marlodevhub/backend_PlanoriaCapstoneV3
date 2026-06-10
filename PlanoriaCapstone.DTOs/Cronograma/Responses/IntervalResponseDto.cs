
namespace PlanoriaCapstone.DTOs.Cronograma.Responses
{
    public class IntervalResponseDto
    {
        public int Id { get; set; }
        public string IntervalType { get; set; }
        public int DurationMinutes { get; set; }
        public int OrderPosition { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public bool IsCompleted { get; set; }
    }
}
