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
        public decimal DonateAmount { get; set; }
        public DateTime Birth { get; set; }
        public int UserId { get; set; }
    }

    public class RequestParticipantCommunityDTO
    {
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public decimal DonateAmount { get; set; }
        public DateTime Birth { get; set; }
        public int UserId { get; set; }
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

    public class RequestParticipantEventDTO {
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public decimal DonateAmount { get; set; }
        public DateTime Birth { get; set; }
        public int UserId { get; set; }
    }

    public class RequestParticipantPostDTO
    {
        public int ParticipantId { get; set; }
        public string ParticipantName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Gender { get; set; }
        public decimal DonateAmount { get; set; }
        public DateTime Birth { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public int Slot { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string StatusName { get; set; }
    }
}