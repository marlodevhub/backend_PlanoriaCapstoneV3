using PlanoriaCapstone.DTOs.Flashcards.Cards.Responses;

namespace PlanoriaCapstone.DTOs.Flashcards.Study.Responses
{
    public class NextCardResponseDto
    {
        public FlashcardResponseDto Flashcard { get; set; }
        public int SessionId { get; set; }
        public int Current { get; set; }
        public int Total { get; set; }
        public int RemainingCards { get; set; }
    }
}
