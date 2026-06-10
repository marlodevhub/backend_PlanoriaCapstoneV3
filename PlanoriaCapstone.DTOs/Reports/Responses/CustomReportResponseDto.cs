namespace PlanoriaCapstone.DTOs.Reports.Responses
{
    public class CustomReportResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Config { get; set; }
        public DateTime GeneratedAt { get; set; }
        public string DownloadUrl { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
