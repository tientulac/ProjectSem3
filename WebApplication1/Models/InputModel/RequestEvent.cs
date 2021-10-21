using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Content { get; set; }
        public int Slot { get; set; }
        public decimal DesiredAmount { get; set; }
        public decimal DonateAmount { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public int Status { get; set; }
    }

    public class RequestEventDTO
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Content { get; set; }
        public int Slot { get; set; }
        public decimal DesiredAmount { get; set; }
        public decimal DonateAmount { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public int Status { get; set; }
        public string SupportTypeName { get; set; }
        public string LocalName { get; set; }
        public string StatusName { get; set; }
    }
}