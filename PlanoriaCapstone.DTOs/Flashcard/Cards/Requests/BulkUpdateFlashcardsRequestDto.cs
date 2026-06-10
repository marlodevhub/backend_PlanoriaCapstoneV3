
namespace PlanoriaCapstone.DTOs.Flashcards.Cards.Requests
{
    public class FlashcardUpdateItem
    {
        public int Id { get; set; }
        public UpdateFlashcardRequestDto Data { get; set; }
    }

    public class BulkUpdateFlashcardsRequestDto
    {
        public List<FlashcardUpdateItem> Updates { get; set; }
    }
}
