using System;
namespace DataLayer.Models
{
    /// <summary>
    /// Represents a VendorQuotes.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class VendorQuotes 
    {
        public int QuoteId { get; set; }
        public string VendorId { get; set; }
        public DateTime DateQuoted { get; set; }
        public string GoodForDays { get; set; }
        public string Comments { get; set; }
    }
}      
