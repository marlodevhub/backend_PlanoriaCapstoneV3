
namespace PlanoriaCapstone.DTOs.Flashcards.Cards.Requests
{
    public class CardOrderItem
    {
        public int Id { get; set; }
        public int Position { get; set; }
    }

    public class ReorderFlashcardsRequestDto
    {
        public List<CardOrderItem> CardOrder { get; set; }
    }
}
