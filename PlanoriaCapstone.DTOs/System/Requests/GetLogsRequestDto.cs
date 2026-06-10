
namespace PlanoriaCapstone.DTOs.System.Requests
{
    public class GetLogsRequestDto
    {
        public string Level { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int Limit { get; set; } = 100;
        public int Offset { get; set; } = 0;
    }
}
