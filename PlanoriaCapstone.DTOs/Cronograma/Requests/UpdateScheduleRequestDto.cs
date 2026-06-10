
namespace PlanoriaCapstone.DTOs.Cronograma.Requests
{
    public class UpdateScheduleRequestDto
    {
        public string Title { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
