
namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class CreateOptionRequestDto
    {
        public string OptionText { get; set; }
        public bool IsCorrect { get; set; }
        public int OrderPosition { get; set; }
    }
}
