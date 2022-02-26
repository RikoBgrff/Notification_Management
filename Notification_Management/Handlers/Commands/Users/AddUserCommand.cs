using MediatR;

namespace Notification_Management.Handlers.Commands
{
    public class AddUserCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
