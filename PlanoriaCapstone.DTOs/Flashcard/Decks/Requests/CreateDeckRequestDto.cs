
namespace PlanoriaCapstone.DTOs.Flashcards.Decks.Requests
{
    public class CreateDeckRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public bool SpacedRepetitionEnabled { get; set; } = true;
    }
}
