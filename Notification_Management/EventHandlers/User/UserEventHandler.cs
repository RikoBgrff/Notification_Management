using MediatR;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Notification_Management.Hubs;
using System.Threading;
using System.Threading.Tasks;

namespace Notification_Management.EventHandlers.User
{
    public class UserEventHandler : INotificationHandler<UserNotification>
    {
        private readonly IHubContext<NotifyHub> hubContext;

        public UserEventHandler(IHubContext<NotifyHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public async Task Handle(UserNotification notification, CancellationToken cancellationToken)
        {
            var notificationJson = JsonConvert.SerializeObject(notification.Notification);
            await hubContext.Clients.Client(notification.Notification.ToConnectionId).SendAsync("ReceiveNotification", notificationJson);

        }
    }
}
