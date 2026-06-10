
namespace PlanoriaCapstone.DTOs.Flashcards.Study.Requests
{
    public class SubmitFlashcardAnswerRequestDto
    {
        public int FlashcardId { get; set; }
        public int SessionId { get; set; }
        public bool KnewIt { get; set; }
        public int ResponseTimeMs { get; set; }
    }
}
