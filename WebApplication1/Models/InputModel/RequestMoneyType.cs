using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestMoneyType
    {
        public int MoneyTypeId { get; set; }
        public string MoneyTypeName { get; set; }
        public double Ratio { get; set; }
    }
}