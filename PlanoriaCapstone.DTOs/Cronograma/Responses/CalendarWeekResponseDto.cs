
namespace PlanoriaCapstone.DTOs.Cronograma.Responses
{
    public class CalendarWeekResponseDto
    {
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }
        public List<CalendarDayResponseDto> Days { get; set; }
    }
}
