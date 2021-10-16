using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class ManagerCommunity
    {
        public int ManagerId { get; set; }
        public int CommunityId { get; set; }
    }
    public class ManagerEvent
    {
        public int ManagerId { get; set; }
        public int EventId { get; set; }
    }
    public class ManagerPost
    {
        public int ManagerId { get; set; }
        public int PostId {get;set;}
    }
    public class ParticipantCommunity
    {
        public int ParticipantId { get; set; }
        public int CommunityId { get; set; }
    }
    public class ParticipantEvent
    {
        public int ParticipantId { get; set; }
        public int EventId { get; set; }
    }
    public class ParticipantPost
    {
        public int ParticipantId { get; set; }
        public int PostId { get; set; }
    }
}