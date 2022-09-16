using System;

using System.Collections.Generic;
using System.Security.Cryptography.Xml;
using System.Net.Http.Headers;
using System.Text;

using Newtonsoft.Json;

using CallQueueMonitorDisplay.Models;

namespace CallQueueMonitorDisplay.Controllers
{
    public class ApiClient
    {
        private const string URL = "https://vcc-na17.8x8.com/api/rtstats/stats/queues.json";

        public bool LoadQueueStatus(CallQueueStatus callQueueStatus)
        {
            bool retval = true;
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var byteArray = Encoding.ASCII.GetBytes("gemshoppingnetwor01:deef38d5e3c94de7b9ba6eb0b17600185626c2c6897468545d5d6996d390d9db");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                try
                {

                    // List data response.
                    HttpResponseMessage response = client.GetAsync(URL).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        int maxLongestWait = 0;

                        Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(result);


                        Console.WriteLine("QueueId, QueueName, QueueType, " +
                            "InProgress, Busy, Assigned, Enabled, LoggedOut, " +
                            "OnBreak, " +
                            "WorkOffline, WaitTransact, QueueSize, LongestWaitTime");

                        foreach (var que in myDeserializedClass.queue)
                        {
                            if (que.QueueName.Equals("Customer Service Priority"))
                            {
                                callQueueStatus.CSAvailable += Convert.ToInt32(que.AgentCountWaitTransact);

                                callQueueStatus.CSTalking += Convert.ToInt32(que.NumberInProgress);

                                callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountOnBreak);
                               // callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                                if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                                {
                                    callQueueStatus.CSOldest = new TimeSpan(0, 0, que.LongestWaitTime);
                                    maxLongestWait = que.LongestWaitTime;
                                }
                                callQueueStatus.CSInQueue += Convert.ToInt32(que.QueueSize);
                            }
                            else if (que.QueueName.Equals("Customer Service Standard"))
                            {
                                callQueueStatus.CSAvailable += Convert.ToInt32(que.AgentCountWaitTransact);

                                callQueueStatus.CSTalking += Convert.ToInt32(que.NumberInProgress);

                                callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountOnBreak);
                               // callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                                if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                                {
                                    callQueueStatus.CSOldest = new TimeSpan(0, 0, que.LongestWaitTime);
                                    maxLongestWait = que.LongestWaitTime;
                                }
                                callQueueStatus.CSInQueue += Convert.ToInt32(que.QueueSize);
                            }
                            //else if (que.QueueName.Equals("Customer Service CB"))
                            //{
                            //    callQueueStatus.CSAvailable += Convert.ToInt32(que.AgentCountWaitTransact);

                            //    callQueueStatus.CSTalking += Convert.ToInt32(que.NumberInProgress);

                            //    callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountOnBreak);
                            //    callQueueStatus.CSInRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                            //    //if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                            //    //{
                            //    //    callQueueStatus.CSOldest = new TimeSpan(0, 0, que.LongestWaitTime);
                            //    //    maxLongestWait = que.LongestWaitTime;
                            //    //}
                            //    callQueueStatus.CSInQueue += Convert.ToInt32(que.QueueSize);
                            //}

                            if (que.QueueName.Equals("Showroom  Priority"))
                            {
                                callQueueStatus.Available += Convert.ToInt32(que.AgentCountWaitTransact);

                                callQueueStatus.Talking += Convert.ToInt32(que.NumberInProgress);

                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountOnBreak);
                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                                if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                                {
                                    callQueueStatus.Oldest = new TimeSpan(0, 0, que.LongestWaitTime);
                                    maxLongestWait = que.LongestWaitTime;
                                }
                                callQueueStatus.InQueue += Convert.ToInt32(que.QueueSize);
                            }
                            else if (que.QueueName.Equals("Showroom  Standard"))
                            {
                                callQueueStatus.Available += Convert.ToInt32(que.AgentCountWaitTransact);

                                callQueueStatus.Talking += Convert.ToInt32(que.NumberInProgress);

                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountOnBreak);
                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                                if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                                {
                                    callQueueStatus.Oldest = new TimeSpan(0, 0, que.LongestWaitTime);
                                    maxLongestWait = que.LongestWaitTime;
                                }
                                callQueueStatus.InQueue += Convert.ToInt32(que.QueueSize);
                            }
                            else if (que.QueueName.Equals("Showroom  CB"))
                            {
                                callQueueStatus.Available += Convert.ToInt32(que.AgentCountWaitTransact);

                                callQueueStatus.Talking += Convert.ToInt32(que.NumberInProgress);

                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountOnBreak);
                                callQueueStatus.InRelease += Convert.ToInt32(que.AgentCountWorkOffline);

                                //if ((que.LongestWaitTime > 0) && (que.LongestWaitTime > maxLongestWait))
                                //{
                                //    callQueueStatus.Oldest = new TimeSpan(0, 0, que.LongestWaitTime);
                                //    maxLongestWait = que.LongestWaitTime;
                                //}
                                callQueueStatus.InQueue += Convert.ToInt32(que.QueueSize);
                            }

                            // Totals done, now set the severity flags for each set.

                            if (callQueueStatus.CSInQueue == 0)
                                callQueueStatus.CSInQueueSeverity = 0;
                            else if (callQueueStatus.CSInQueue >= 3)
                                callQueueStatus.CSInQueueSeverity = 2;
                            else
                                callQueueStatus.CSInQueueSeverity = 1;

                            if (callQueueStatus.CSOldest.TotalSeconds == 0)
                                callQueueStatus.CSOldestSeverity = 0;
                            else if (callQueueStatus.CSOldest.TotalSeconds >= 60)
                                callQueueStatus.CSOldestSeverity = 2;
                            else
                                callQueueStatus.CSOldestSeverity = 1;

                            if (callQueueStatus.InQueue == 0)
                                callQueueStatus.InQueueSeverity = 0;
                            else if (callQueueStatus.InQueue >= 3)
                                callQueueStatus.InQueueSeverity = 2;
                            else
                                callQueueStatus.InQueueSeverity = 1;

                            if (callQueueStatus.Oldest.TotalSeconds == 0)
                                callQueueStatus.OldestSeverity = 0;
                            else if (callQueueStatus.Oldest.TotalSeconds >= 60)
                                callQueueStatus.OldestSeverity = 2;
                            else
                                callQueueStatus.OldestSeverity = 1;

                            //Console.WriteLine("QueueId {0}", que.QueueId);
                            //Console.WriteLine("QueueName {0}", que.QueueName);
                            //Console.WriteLine("QueueType {0}", que.QueueType);
                            //Console.WriteLine("NumberInProgress {0}", que.NumberInProgress);
                            //Console.WriteLine("AssignedAgentCount {0}", que.AssignedAgentCount);
                            //Console.WriteLine("EnabledAgentCount {0}", que.EnabledAgentCount);
                            //Console.WriteLine("LongestWaitTime {0}", que.LongestWaitTime);

                            if ((que.QueueName.Equals("Customer Service Priority")) || (que.QueueName.Equals("Customer Service Standard")) || (que.QueueName.Equals("Customer Service CB")))
                            {
                                Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12}", que.QueueId, que.QueueName, que.QueueType,
                                    que.NumberInProgress, que.AgentCountBusy, que.AssignedAgentCount, que.EnabledAgentCount, que.AgentCountLoggedOut,
                                    que.AgentCountOnBreak, que.AgentCountWorkOffline, que.AgentCountWaitTransact, que.QueueSize, que.LongestWaitTime);

                            }
                        }
                        retval = response.IsSuccessStatusCode;
                    }
                    else
                    {
                        Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                        retval = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    retval = false;
                }
            }
            return retval;
        }
    }
}