using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.InputModel;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseManager : ResponseBase
    {
        public List<RequestManager> Data { get; set; }
        public List<RequestManagerCommunityDTO> DataCom { get; set; }
        public List<RequestManagerEventDTO> DataEvent { get; set; }
        public List<RequestManagerPostDTO> DataPost { get; set; }
    }
}