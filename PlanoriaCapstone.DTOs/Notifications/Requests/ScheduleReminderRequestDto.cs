
namespace PlanoriaCapstone.DTOs.Notifications.Requests
{
    public class ScheduleReminderRequestDto
    {
        public int ScheduleId { get; set; }
        public int RemindMinutesBefore { get; set; }
    }
}
