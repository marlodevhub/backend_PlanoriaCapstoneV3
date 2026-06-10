
namespace PlanoriaCapstone.DTOs.IA.Responses
{
    public class TokenUsageResponseDto
    {
        public int TotalTokensUsed { get; set; }
        public decimal EstimatedCost { get; set; }
        public int RequestsCount { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
    }
}
