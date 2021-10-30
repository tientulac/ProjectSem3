using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Admin { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public int UserCategory { get; set; }
        public string UserCategoryName { get; set; }
        public string StatusName { get; set; }
    }
}