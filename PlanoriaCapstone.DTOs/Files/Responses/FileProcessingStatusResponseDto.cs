
namespace PlanoriaCapstone.DTOs.Files.Responses
{
    public class FileProcessingStatusResponseDto
    {
        public int FileId { get; set; }
        public string Status { get; set; }
        public int ProgressPercentage { get; set; }
        public int EstimatedTimeRemaining { get; set; }
    }
}
