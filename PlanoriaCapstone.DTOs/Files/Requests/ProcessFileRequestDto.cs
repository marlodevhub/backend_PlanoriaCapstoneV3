
namespace PlanoriaCapstone.DTOs.Files.Requests
{
    public class ProcessFileRequestDto
    {
        public int FileId { get; set; }
        public string ContentFormat { get; set; }
        public string Topic { get; set; }
        public int TargetCourseId { get; set; }
        public string Difficulty { get; set; }
    }
}
