using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Notification_Management.Handlers.Queries.Users;
using Notification_Management.Hubs;
using Notification_Management.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Notification_Management.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator mediator;
        private readonly IHubContext<NotifyHub> hubContext;

        public HomeController(ILogger<HomeController> logger, IMediator mediator, IHubContext<NotifyHub> hubContext)
        {
            this.hubContext = hubContext;
            _logger = logger;
            this.mediator = mediator;
        }

        public IActionResult Index()
        {
            var data = mediator.Send(new GetAllUsersQuery());
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
