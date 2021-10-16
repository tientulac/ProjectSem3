using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestCommunityDonate
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Slot { get; set; }
        public decimal TotalAmount { get; set; }
        public int TypeId { get; set; }
        public int LocalId { get; set; }
    }
    public class RequestCommunityDonateDTO
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Slot { get; set; }
        public decimal TotalAmount { get; set; }
        public int TypeId { get; set; }
        public int LocalId { get; set; }
        public string TypeName { get; set; }
        public string LocalName { get; set; }
    }
}