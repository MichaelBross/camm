using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class VendorQuote 
    {	
		[Key]
        public int QuoteId { get; set; }
        public string VendorId { get; set; }
        public DateTime DateQuoted { get; set; }
        public string GoodForDays { get; set; }
        public string Comments { get; set; }
    }
}      
