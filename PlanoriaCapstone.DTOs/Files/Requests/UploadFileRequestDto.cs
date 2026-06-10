
using Microsoft.AspNetCore.Http;

namespace PlanoriaCapstone.DTOs.Files.Requests
{
    public class UploadFileRequestDto
    {
        public IFormFile File { get; set; }
        public string FileType { get; set; }
        public int CourseId { get; set; }
    }
}
