using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseParticipant : ResponseBase
    {
        public List<RequestParticipant> Data { get; set;}
        public List<RequestParticipantCommunityDTO> DataCom { get; set; }
        public List<RequestParticipantEventDTO> DataEvent { get; set; }
        public List<RequestParticipantPostDTO> DataPost { get; set; }
    }
}