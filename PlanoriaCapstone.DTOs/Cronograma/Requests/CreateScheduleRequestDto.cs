
namespace PlanoriaCapstone.DTOs.Cronograma.Requests
{
    public class CreateScheduleRequestDto
    {
        public string Title { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<int> CourseIds { get; set; }
        public List<CreateIntervalRequestDto> Intervals { get; set; }
        public List<ScheduleContentRequestDto> Content { get; set; }
    }
}
