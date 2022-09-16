using Microsoft.AspNetCore.Mvc;
using CallQueueMonitorDisplay.Models;

namespace CallQueueMonitorDisplay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class _8x8StatusController : Controller
    {
        private readonly ILogger<_8x8StatusController> _logger;

        public _8x8StatusController(ILogger<_8x8StatusController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get8x8QueueStatus")]
        public CallQueueStatus Get()
        {
            ApiClient client = new ApiClient();

            CallQueueStatus callQueueStatus = new CallQueueStatus();

            client.LoadQueueStatus(callQueueStatus);

            return (callQueueStatus);
        }

    }
}