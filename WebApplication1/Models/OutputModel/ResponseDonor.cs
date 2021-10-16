using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseDonor : ResponseBase
    {
        public List<RequestDonorDTO> Data { get; set; }
    }
}