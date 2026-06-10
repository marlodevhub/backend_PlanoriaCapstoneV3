
namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class SubmitAnswerRequestDto
    {
        public int AttemptId { get; set; }
        public int QuestionId { get; set; }
        public int? SelectedOptionId { get; set; }
        public string ShortAnswerText { get; set; }
    }
}
