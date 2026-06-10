
namespace PlanoriaCapstone.DTOs.Flashcards.Decks.Requests
{
    public class UpdateDeckRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? SpacedRepetitionEnabled { get; set; }
        public bool? IsArchived { get; set; }
    }
}
