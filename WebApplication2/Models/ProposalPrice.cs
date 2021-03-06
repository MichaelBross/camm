using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ProposalPrice 
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
