
namespace PlanoriaCapstone.DTOs.Cronograma.Responses
{
    public class ScheduleListResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsCompleted { get; set; }
        public decimal ProgressPercentage { get; set; }
        public string CourseName { get; set; }
    }
}
