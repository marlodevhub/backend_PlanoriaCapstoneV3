using PlanoriaCapstone.DTOs.IA.Responses;

namespace PlanoriaCapstone.DTOs.Files.Responses
{
    public class FileHistoryResponseDto
    {
        public int Id { get; set; }
        public string OriginalFilename { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public List<GeneratedContentResponseDto> GeneratedContent { get; set; }
    }
}
