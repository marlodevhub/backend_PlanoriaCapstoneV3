
namespace PlanoriaCapstone.DTOs.Flashcards.Study.Requests
{
    public class GetDueCardsRequestDto
    {
        public int DeckId { get; set; }
        public int Limit { get; set; } = 20;
        public bool IncludeOverdue { get; set; } = true;
    }
}
