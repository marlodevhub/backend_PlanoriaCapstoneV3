
namespace PlanoriaCapstone.DTOs.System.Responses
{
    public class CacheStatsResponseDto
    {
        public int Hits { get; set; }
        public int Misses { get; set; }
        public decimal HitRate { get; set; }
        public long Size { get; set; }
        public DateTime? LastClearedAt { get; set; }
    }
}
