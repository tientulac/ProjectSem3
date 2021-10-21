using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class RequestDonor
    {
        public int DonorId { get; set; }
        public string DonorName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId {get;set;}
    }

    public class RequestDonorDTO
    {
        public int DonorId { get; set; }
        public string DonorName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }
        public int SupportTypeId { get; set; }
        public int LocalId { get; set; }
        public string SupportTypeName { get; set; }
        public string LocalName { get; set; }
        public string StatusName { get; set; }
    }
}