using MediatR;
using Notification_Management.EventHandlers.User;
using Notification_Management.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Notification_Management.Handlers.Commands
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, int>
    {

        public AddUserCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }
        private readonly IMediator mediator;
        private List<User> users = new List<User>();

        public async Task<int> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {

            string message = string.Empty;
            try
            {
                User u = new User
                {
                    Id = request.Id,
                    Username = request.Username,
                    Password = request.Password,
                };
                users.Add(u);
                message = "User added";
            }
            catch (System.Exception)
            {
                message = "Error occured";
            }
            await mediator.Publish(new UserNotification()
            {
                Message = message
            });
            return 1;  

        }

    }
}
