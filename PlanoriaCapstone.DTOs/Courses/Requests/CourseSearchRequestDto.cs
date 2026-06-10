namespace PlanoriaCapstone.DTOs.Courses.Requests
{
    public class CourseSearchRequestDto
    {
        public string Query { get; set; }
        public string Status { get; set; }
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
        public int PerPage { get; set; } = 10;
        public int Page { get; set; } = 1;
    }
}
