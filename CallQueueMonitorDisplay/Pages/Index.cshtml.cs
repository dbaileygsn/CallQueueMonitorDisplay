using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using CallQueueMonitorDisplay.Controllers;
using CallQueueMonitorDisplay.Models;

namespace CallQueueMonitorDisplay.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string Mode { get; set; }

        
        [BindProperty(SupportsGet = true)]
        public QueueModel QueueData { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Mode))
                Mode = "Showroom";

            // Load queue values from 8X8 using QueueModel

            ApiClient client = new ApiClient();

            CallQueueStatus callQueueStatus = new CallQueueStatus();

            client.LoadQueueStatus(callQueueStatus);

            QueueData = new QueueModel();

            if (Mode.Equals("Customer Service"))
            {
                QueueData.Available = callQueueStatus.CSAvailable;
                QueueData.InQueue = callQueueStatus.CSInQueue;
                QueueData.InRelease = callQueueStatus.CSInRelease;
                QueueData.Talking = callQueueStatus.CSTalking;
                QueueData.Oldest = callQueueStatus.CSOldest;
                QueueData.OldestSeverity = callQueueStatus.CSOldestSeverity;
                QueueData.InQueueSeverity = callQueueStatus.CSInQueueSeverity;
            }
            else
            {
                QueueData.Available = callQueueStatus.Available;
                QueueData.InQueue = callQueueStatus.InQueue;
                QueueData.InRelease = callQueueStatus.InRelease;
                QueueData.Talking = callQueueStatus.Talking;
                QueueData.Oldest = callQueueStatus.Oldest;

            }
        }

        // No Post methods

    }
}