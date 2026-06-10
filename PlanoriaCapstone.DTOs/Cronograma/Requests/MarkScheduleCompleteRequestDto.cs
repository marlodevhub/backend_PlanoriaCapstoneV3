
namespace PlanoriaCapstone.DTOs.Cronograma.Requests
{
    public class CompletedContent
    {
        public string ContentType { get; set; }
        public int ContentId { get; set; }
        public bool Completed { get; set; }
    }

    public class MarkScheduleCompleteRequestDto
    {
        public int ScheduleId { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public List<CompletedContent> CompletedContent { get; set; }
    }
}
