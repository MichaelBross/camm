using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class VendorQuoteDetail 
    {	
		[Key]
        public int DetailId { get; set; }
        public int QuoteId { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string Mfg { get; set; }
        public string MfgPartNumber { get; set; }
        public string Minimum { get; set; }
        public int LeadTime { get; set; }
        public string Putup { get; set; }
        public double? Qty1 { get; set; }
        public string UM1 { get; set; }
        public decimal? Price1 { get; set; }
        public double? Qty2 { get; set; }
        public string UM2 { get; set; }
        public decimal? Price2 { get; set; }
        public double? Qty3 { get; set; }
        public string UM3 { get; set; }
        public decimal? Price3 { get; set; }
        public double? Qty4 { get; set; }
        public string UM4 { get; set; }
        public decimal? Price4 { get; set; }
        public double? Qty5 { get; set; }
        public string UM5 { get; set; }
        public decimal? Price5 { get; set; }
        public string Notes { get; set; }
    }
}      
