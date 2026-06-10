
namespace PlanoriaCapstone.DTOs.Flashcards.Study.Requests
{
    public class StartStudySessionRequestDto
    {
        public int DeckId { get; set; }
        public string SessionType { get; set; } = "normal";
        public List<int> IncludeCards { get; set; }
    }
}
