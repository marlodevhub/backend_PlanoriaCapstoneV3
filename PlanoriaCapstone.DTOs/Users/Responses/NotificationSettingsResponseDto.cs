namespace PlanoriaCapstone.DTOs.Users.Responses
{
    public class NotificationSettingsResponseDto
    {
        public bool StudyReminders { get; set; }
        public bool ExamAlerts { get; set; }
        public bool AchievementAlerts { get; set; }
        public string ReminderTime { get; set; }
        public int ReminderDaysBeforeExam { get; set; }
    }
}
