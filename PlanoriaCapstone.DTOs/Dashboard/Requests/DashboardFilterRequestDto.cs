
namespace PlanoriaCapstone.DTOs.Dashboard.Requests
{
    public class DateRange
    {
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }

    public class DashboardFilterRequestDto
    {
        public DateRange DateRange { get; set; }
        public List<int> CourseIds { get; set; }
        public bool IncludeArchived { get; set; }
    }
}
