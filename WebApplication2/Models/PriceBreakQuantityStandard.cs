using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class PriceBreakQuantityStandard 
    {	
		[Key]
        public int PriceBreakId { get; set; }
        public int Quantity { get; set; }
    }
}      
