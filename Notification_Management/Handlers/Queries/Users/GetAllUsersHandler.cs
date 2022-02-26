using MediatR;
using Notification_Management.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Notification_Management.Handlers.Queries.Users
{
    public class GetAllUsersQuery : IRequest<IEnumerable<User>>
    {

    }

    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        public GetAllUsersHandler()
        {

        }
        public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var list = new List<User>
            {
                new User{Id=1, Username="rikobgrff"}
            };
            return list;
        }
    }
}
