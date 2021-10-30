using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestUserFunction
    {
        public int UserId { get; set; }
        public int FunctionId { get; set; }
        public List<int> list_user_function { get; set; }
    }
}