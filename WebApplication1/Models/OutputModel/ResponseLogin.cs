using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.OutputModel
{
    public class ResponseLogin : ResponseBase
    {
        public string Token { get; set; }
        public UserInfo Info { get; set; }
    }
}