
namespace PlanoriaCapstone.DTOs.Notifications.Responses
{
    public class PushDeviceResponseDto
    {
        public int Id { get; set; }
        public string Platform { get; set; }
        public string DeviceName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastUsedAt { get; set; }
    }
}
