using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseCommunityDonate : ResponseBase
    {
        public List<RequestCommunityDonateDTO> Data { get; set; }
    }
}