using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestParticipant
    {
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public string GenderName { get; set; }
        public decimal DonateAmount { get; set; }
        public DateTime Birth { get; set; }
        public int UserId { get; set; }
        public int CommunityId { get; set; }
        public int EventId { get; set; }
        public int PostId { get; set; }
        public decimal Money { get; set; }
        public int MoneyTypeId { get; set; }
        public string ContentMail { get; set; }
        public List<int> List_com { get; set; }
        public List<int> List_event { get; set; }
        public List<int> List_post { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserCategory { get; set; }
    }

    public class RequestParticipantCommunityDTO : RequestParticipant
    {
        public string CommunityName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int Slot { get; set; }
        public decimal TotalAmount { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public string SupportTypeName { get; set; }
        public string LocalName { get; set; }
        public string MoneyTypeName { get; set; }
        public double Ratio { get; set; }
    }

    public class RequestParticipantEventDTO : RequestParticipant
    {
        public string EventName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Content { get; set; }
        public int Slot { get; set; }
        public decimal DesiredAmount { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public int Status { get; set; }
        public string SupportTypeName { get; set; }
        public string LocalName { get; set; }
        public string StatusName { get; set; }
        public decimal DonateByParticipant { get; set; }
        public string MoneyTypeName { get; set; }
        public double Ratio { get; set; }
    }

    public class RequestParticipantPostDTO : RequestParticipant
    {
        public string PostName { get; set; }
        public int Slot { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int SupportTypeId { get; set; }
        public string SupportTypeName { get; set; }
        public string StatusName { get; set; }
        public int PostTypeId { get; set; }
        public string PostTypeName { get; set; }
        public string MoneyTypeName { get; set; }
        public double Ratio { get; set; }
    }
}