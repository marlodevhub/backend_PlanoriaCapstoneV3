
namespace PlanoriaCapstone.DTOs.Cronograma.Requests
{
    public class GetScheduleByDateRangeRequestDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? CourseId { get; set; }
    }
}
