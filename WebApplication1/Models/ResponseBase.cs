﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ResponseBase
    {
        public StatusID Status { get; set; }
        public string Message { get; set; }
    }
}