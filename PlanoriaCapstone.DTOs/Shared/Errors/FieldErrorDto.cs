
namespace PlanoriaCapstone.DTOs.Shared.Errors
{
    public class FieldErrorDto
    {
        public string Field { get; set; }
        public string Message { get; set; }
        public object RejectedValue { get; set; }
    }
}
