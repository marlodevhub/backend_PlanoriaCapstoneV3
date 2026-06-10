
namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class QuestionOrderItem
    {
        public int Id { get; set; }
        public int OrderPosition { get; set; }
    }

    public class ReorderQuestionsRequestDto
    {
        public List<QuestionOrderItem> QuestionOrder { get; set; }
    }
}
