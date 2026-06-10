
namespace PlanoriaCapstone.DTOs.Flashcards.Cards.Requests
{
    public class BulkCreateFlashcardsRequestDto
    {
        public int DeckId { get; set; }
        public List<CreateFlashcardRequestDto> Cards { get; set; }
    }
}
