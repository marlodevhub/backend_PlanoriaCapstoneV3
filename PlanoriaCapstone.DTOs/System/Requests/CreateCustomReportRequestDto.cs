
namespace PlanoriaCapstone.DTOs.System.Requests
{
    public class CreateCustomReportRequestDto
    {
        public string Name { get; set; }
        public List<string> Filters { get; set; }
        public List<string> Metrics { get; set; }
        public List<string> Schedule { get; set; }
        public string Format { get; set; }
    }
}
