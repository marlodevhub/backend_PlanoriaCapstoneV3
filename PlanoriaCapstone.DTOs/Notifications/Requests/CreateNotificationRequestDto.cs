
namespace PlanoriaCapstone.DTOs.Notifications.Requests
{
    public class CreateNotificationRequestDto
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string RelatedEntityType { get; set; }
        public int? RelatedEntityId { get; set; }
        public DateTime? ScheduledFor { get; set; }
    }
}
