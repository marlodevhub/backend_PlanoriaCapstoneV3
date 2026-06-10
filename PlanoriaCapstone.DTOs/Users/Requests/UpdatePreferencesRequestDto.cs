namespace PlanoriaCapstone.DTOs.Users.Requests
{
    public class UpdatePreferencesRequestDto
    {
        public string Theme { get; set; }
        public string PreferredLanguage { get; set; }
        public bool? NotificationEnabled { get; set; }
        public bool? EmailNotifications { get; set; }
        public List<int> DefaultSpacedRepetitionDays { get; set; }
    }
}
