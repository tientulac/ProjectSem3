using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestUserEvent
    {
        public int UserEventId { get; set; }
        public int TypeEvent { get; set; }
        public int Perform { get; set; }
        public string Content { get; set; }
        public DateTime Moment { get; set; }
        public string IPAddress { get; set; }
        public string UserName { get; set; }
        public string TypeEventName { get; set; }
        public string PerformName { get; set; }
    }
}