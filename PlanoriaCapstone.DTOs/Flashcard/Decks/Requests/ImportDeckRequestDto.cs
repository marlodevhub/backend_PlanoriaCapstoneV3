
using Microsoft.AspNetCore.Http;

namespace PlanoriaCapstone.DTOs.Flashcards.Decks.Requests
{
    public class ImportDeckRequestDto
    {
        public string Format { get; set; }
        public IFormFile File { get; set; }
        public int TargetCourseId { get; set; }
        public bool ReplaceDuplicates { get; set; }
    }
}
