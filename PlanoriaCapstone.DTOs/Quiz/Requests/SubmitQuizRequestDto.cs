
namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class SubmitQuizRequestDto
    {
        public int AttemptId { get; set; }
        public List<SubmitAnswerRequestDto> Answers { get; set; }
    }
}
