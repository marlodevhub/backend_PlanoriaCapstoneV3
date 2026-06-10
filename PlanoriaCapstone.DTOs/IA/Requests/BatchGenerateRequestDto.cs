
namespace PlanoriaCapstone.DTOs.IA.Requests
{
    public class BatchGenerateRequestDto
    {
        public List<int> Files { get; set; }
        public string ContentType { get; set; }
        public int TargetCourseId { get; set; }
    }
}
