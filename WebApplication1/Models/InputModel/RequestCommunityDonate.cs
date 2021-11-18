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
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
    }
    public class RequestCommunityDonateDTO : RequestCommunityDonate
    {
        public string SupportTypeName { get; set; }
        public string LocalName { get; set; }
    }
}