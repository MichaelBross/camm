using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a purchase_requests.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class purchase_requests 
    {	
		[Key]
        public int purchase_requestsId { get; set; }
        public string ItemNumber { get; set; }
        public string WorkOrder { get; set; }
        public string QtyRequired { get; set; }
        public string EstimatedPrice { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public string RequestedBy { get; set; }
        public string Mfg_Vendor { get; set; }
        public string NeededBy { get; set; }
    }
}      
