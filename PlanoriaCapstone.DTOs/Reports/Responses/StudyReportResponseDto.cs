namespace PlanoriaCapstone.DTOs.Reports.Responses
{
    public class StudyTimeByCourse
    {
        public string CourseName { get; set; }
        public int Minutes { get; set; }
    }

    public class StudyTimeByHour
    {
        public int Hour { get; set; }
        public int Minutes { get; set; }
    }

    public class StudyReportResponseDto
    {
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal TotalStudyHours { get; set; }
        public int AverageDailyMinutes { get; set; }
        public List<string> MostStudiedCourses { get; set; }
        public List<StudyTimeByCourse> StudyTimeByCourse { get; set; }
        public List<StudyTimeByHour> StudyTimeByHour { get; set; }
        public decimal ConsistencyScore { get; set; }
    }
}
