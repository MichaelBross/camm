using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Routings.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Routings 
    {	
		[Key]
        public int RoutingId { get; set; }
        public string Description { get; set; }
    }
}      
