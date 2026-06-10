
namespace PlanoriaCapstone.DTOs.IA.Responses
{
    public class AIConfigResponseDto
    {
        public string Provider { get; set; }
        public string Model { get; set; }
        public int MaxTokens { get; set; }
        public decimal Temperature { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastUsedAt { get; set; }
    }
}
