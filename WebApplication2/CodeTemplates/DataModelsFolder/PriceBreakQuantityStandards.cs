using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a PriceBreakQuantityStandards.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class PriceBreakQuantityStandards 
    {	
		[Key]
        public int PriceBreakId { get; set; }
        public int Quantity { get; set; }
    }
}      
