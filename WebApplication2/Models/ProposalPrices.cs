using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ProposalPrices.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ProposalPrices 
    {	
		[Key]
        public int ProposalPriceId { get; set; }
        public int DetailId { get; set; }
        public string ProposalNumber { get; set; }
        public double QtyToBuild { get; set; }
        public int? AvailableLeadTime { get; set; }
        public double? PriceBreakQty { get; set; }
        public decimal? Price { get; set; }
        public int? LeadTime { get; set; }
    }
}      
