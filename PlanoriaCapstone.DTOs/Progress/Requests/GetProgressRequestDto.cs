
namespace PlanoriaCapstone.DTOs.Progress.Requests
{
    public class GetProgressRequestDto
    {
        public int? CourseId { get; set; }
        public int? DeckId { get; set; }
        public int? QuizId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
