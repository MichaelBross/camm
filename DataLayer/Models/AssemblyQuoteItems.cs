using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a AssemblyQuoteItems.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyQuoteItems 
    {
        public int AssyQuoteItemId { get; set; }
        public int AssyQuoteId { get; set; }
        public int ProposalPriceId { get; set; }
        public double QtyRequired { get; set; }
    }
}      
