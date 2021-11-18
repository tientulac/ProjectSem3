using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel 
{
    public class RequestCharityFund
    {
        public int FundId { get; set; }
        public string FundName { get; set; }
        public decimal TotalAmount { get; set; }
        public int SupportTypeId { get; set; }
        public string Image { get; set; }
    }

    public class RequestCharityFundDTO : RequestCharityFund
    {
        public string SupportTypeName { get; set; }
    }
}
