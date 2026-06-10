
namespace PlanoriaCapstone.DTOs.Files.Requests
{
    public class RegenerateContentRequestDto
    {
        public int GeneratedContentId { get; set; }
        public string AdjustComplexity { get; set; }
        public List<string> FocusOnTopics { get; set; }
    }
}
