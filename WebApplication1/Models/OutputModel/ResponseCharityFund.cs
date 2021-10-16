using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseCharityFund : ResponseBase
    {
        public List<RequestCharityFundDTO> Data { get; set; }
    }
}