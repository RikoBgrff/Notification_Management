using MediatR;
using Notification_Management.Commons;

namespace Notification_Management.EventHandlers.User
{
    public class UserNotification : INotification
    {
        public Notification Notification { get; set; }
        public string Message { get; set; }
    }
}
