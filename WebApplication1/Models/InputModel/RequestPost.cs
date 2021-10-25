using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestPost
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public int Slot { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int SupportTypeId { get; set; }
        public int PostTypeId { get; set; }
    }

    public class RequestPostDTO
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public int Slot { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int SupportTypeId { get; set; }
        public string SupportTypeName { get; set; }
        public string StatusName { get; set; }
        public int PostTypeId { get; set; }
        public string PostTypeName { get; set; }
        public bool checkLock { get; set; }
        public List<RequestPost> list_post { get; set; }
    }
}