﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public int UserID { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public int UserCategory { get; set; }
    }
}