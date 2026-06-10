
namespace PlanoriaCapstone.DTOs.Notifications.Responses
{
    public class NotificationResponseDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string RelatedEntityType { get; set; }
        public int? RelatedEntityId { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ScheduledFor { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
