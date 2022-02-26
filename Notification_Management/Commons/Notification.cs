namespace Notification_Management.Commons
{
    public class Notification
    {
        public string Message { get; set; }
        public string ToConnectionId { get; set; }
        public string FromConnectionId { get; set; }
        public int Type { get; set; } = (int)NotificationType.Succsess;
    }
    public enum NotificationType
    {
        Succsess,
        Warning,
        Pending,
    };
}
