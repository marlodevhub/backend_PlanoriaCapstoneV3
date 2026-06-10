
namespace PlanoriaCapstone.DTOs.Users.Responses
{
    public class UserPreferencesResponseDto
    {
        public string Theme { get; set; }
        public string PreferredLanguage { get; set; }
        public bool NotificationEnabled { get; set; }
        public bool EmailNotifications { get; set; }
        public List<int> DefaultSpacedRepetitionDays { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
