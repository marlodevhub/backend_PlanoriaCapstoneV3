
namespace PlanoriaCapstone.DTOs.Files.Responses
{
    public class FileDownloadUrlResponseDto
    {
        public string DownloadUrl { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string Filename { get; set; }
        public long FileSize { get; set; }
    }
}
