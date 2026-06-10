
namespace PlanoriaCapstone.DTOs.IA.Requests
{
    public class ImproveContentRequestDto
    {
        public int GeneratedContentId { get; set; }
        public string Feedback { get; set; }
        public string AdjustComplexity { get; set; }
        public List<string> FocusTopics { get; set; }
    }
}
