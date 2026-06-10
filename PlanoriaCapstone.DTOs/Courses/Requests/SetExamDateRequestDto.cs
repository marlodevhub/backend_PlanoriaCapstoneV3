namespace PlanoriaCapstone.DTOs.Courses.Requests
{
    public class SetExamDateRequestDto
    {
        public DateTime ExamDate { get; set; }
        public string ExamTime { get; set; }
        public bool NotifyMe { get; set; }
    }
}
