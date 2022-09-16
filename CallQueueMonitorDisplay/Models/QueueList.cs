using Newtonsoft.Json;

namespace CallQueueMonitorDisplay.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Queue
    {
        [JsonProperty("agent-count-busy")]
        public int AgentCountBusy { get; set; }

        [JsonProperty("agent-count-loggedOut")]
        public int AgentCountLoggedOut { get; set; }

        [JsonProperty("agent-count-onBreak")]
        public int AgentCountOnBreak { get; set; }

        [JsonProperty("agent-count-postProcess")]
        public int AgentCountPostProcess { get; set; }

        [JsonProperty("agent-count-waitTransact")]
        public int AgentCountWaitTransact { get; set; }

        [JsonProperty("agent-count-workOffline")]
        public int AgentCountWorkOffline { get; set; }

        [JsonProperty("day-abandoned")]
        public int DayAbandoned { get; set; }

        [JsonProperty("day-accepted")]
        public int DayAccepted { get; set; }

        [JsonProperty("day-avg-duration")]
        public int DayAvgDuration { get; set; }

        [JsonProperty("day-avg-wait-time")]
        public int DayAvgWaitTime { get; set; }

        [JsonProperty("day-queued")]
        public int DayQueued { get; set; }

        [JsonProperty("day-sla-activity")]
        public int DaySlaActivity { get; set; }

        [JsonProperty("assigned-agent-count")]
        public int AssignedAgentCount { get; set; }

        [JsonProperty("enabled-agent-count")]
        public int EnabledAgentCount { get; set; }

        [JsonProperty("longest-wait-time")]
        public int LongestWaitTime { get; set; }

        [JsonProperty("media-type")]
        public string MediaType { get; set; }

        [JsonProperty("number-in-offered")]
        public int NumberInOffered { get; set; }

        [JsonProperty("number-in-progress")]
        public int NumberInProgress { get; set; }

        [JsonProperty("queue-id")]
        public int QueueId { get; set; }

        [JsonProperty("queue-name")]
        public string QueueName { get; set; }

        [JsonProperty("queue-size")]
        public int QueueSize { get; set; }

        [JsonProperty("queue-type")]
        public string QueueType { get; set; }

        [JsonProperty("sla-activity")]
        public int SlaActivity { get; set; }

        [JsonProperty("sla-target")]
        public int SlaTarget { get; set; }

        [JsonProperty("thirty-min-abandoned")]
        public int ThirtyMinAbandoned { get; set; }

        [JsonProperty("thirty-min-accepted")]
        public int ThirtyMinAccepted { get; set; }

        [JsonProperty("thirty-min-avg-duration")]
        public int ThirtyMinAvgDuration { get; set; }

        [JsonProperty("thirty-min-avg-wait-time")]
        public int ThirtyMinAvgWaitTime { get; set; }

        [JsonProperty("thirty-min-longest-wait-time")]
        public int ThirtyMinLongestWaitTime { get; set; }

        [JsonProperty("thirty-min-queued")]
        public int ThirtyMinQueued { get; set; }

        [JsonProperty("thirty-min-sla-activity")]
        public int ThirtyMinSlaActivity { get; set; }
    }

    public class Root
    {
        public List<Queue> queue { get; set; }
    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


}



/*
 * 
 * 
 *
 *
    public class Queue
    {
        public int agent-count-busy { get; set; }
        public int agent-count-loggedOut { get; set; }
        public int agent-count-onBreak { get; set; }
        public int agent-count-postProcess { get; set; }
        public int agent-count-waitTransact { get; set; }
        public int agent-count-workOffline { get; set; }
        public int day-abandoned { get; set; }
        public int day-accepted { get; set; }
        public int day-avg-duration { get; set; }
        public int day-avg-wait-time { get; set; }
        public int day-queued { get; set; }
        public int day-sla-activity { get; set; }
        public int assigned-agent-count { get; set; }
        public int enabled-agent-count { get; set; }
        public int longest-wait-time { get; set; }
        public string media-type { get; set; }
        public int number-in-offered { get; set; }
        public int number-in-progress { get; set; }
        public int queue-id { get; set; }
        public string queue-name { get; set; }
        public int queue-size { get; set; }
        public string queue-type { get; set; }
        public int sla-activity { get; set; }
        public int sla-target { get; set; }
        public int thirty-min-abandoned { get; set; }
        public int thirty-min-accepted { get; set; }
        public int thirty-min-avg-duration { get; set; }
        public int thirty-min-avg-wait-time { get; set; }
        public int thirty-min-longest-wait-time { get; set; }
        public int thirty-min-queued { get; set; }
        public int thirty-min-sla-activity { get; set; }
    }

    public class Example
    {
        public IList<Queue> queue { get; set; }
    }

 */
