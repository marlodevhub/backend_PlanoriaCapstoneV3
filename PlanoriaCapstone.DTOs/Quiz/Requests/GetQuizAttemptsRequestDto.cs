namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class GetQuizAttemptsRequestDto
    {
        public int QuizId { get; set; }
        public int? Limit { get; set; }
        public string SortBy { get; set; }
    }
}
