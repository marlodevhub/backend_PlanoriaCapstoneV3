
namespace PlanoriaCapstone.DTOs.Quiz.Requests
{
    public class UpdateOptionRequestDto
    {
        public string OptionText { get; set; }
        public bool? IsCorrect { get; set; }
        public int? OrderPosition { get; set; }
    }
}
