namespace CallQueueMonitorDisplay.Models
{
    public class QueueModel
    {

        public TimeSpan Oldest { get; set; }

        public int OldestSeverity { get; set; }

        public int InQueue { get; set; }

        public int InQueueSeverity { get; set; }

        public int Available { get; set; }

        public int Talking { get; set; }

        public int InRelease { get; set; }


        //public TimeSpan CSOldest { get; set; }

        //public int CSOldestSeverity { get; set; }

        //public int CSInQueue { get; set; }

        //public int CSInQueueSeverity { get; set; }

        //public int CSAvailable { get; set; }

        //public int CSTalking { get; set; }

        //public int CSInRelease { get; set; }


    }

}
