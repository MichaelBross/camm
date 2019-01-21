using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AssemblyQuotes.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyQuotes 
    {	
		[Key]
        public int AssyQuoteId { get; set; }
        public string AssemblyNumber { get; set; }
        public string ProposalNumber { get; set; }
        public int QtyToBuild { get; set; }
        public decimal? MaterialCost { get; set; }
        public decimal? EstLaborCost { get; set; }
        public int? MaterialLeadTime { get; set; }
        public int? ShipmentLeadTime { get; set; }
        public decimal? SellingPrice { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Status { get; set; }
        public int? AssyQuoteGoodFor { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? AvailableLeadTime { get; set; }
        public string Notes { get; set; }
    }
}      
