using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserCategory { get; set; }
    }
}