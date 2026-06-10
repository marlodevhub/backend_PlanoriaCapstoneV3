
namespace PlanoriaCapstone.DTOs.Flashcards.Study.Requests
{
    public class ScheduleReviewRequestDto
    {
        public int FlashcardId { get; set; }
        public DateTime? ForceDate { get; set; }
    }
}
