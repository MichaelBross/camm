using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Traveler.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Traveler 
    {	
		[Key]
        public int TravelerId { get; set; }
        public string WoNumber { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
    }
}      
