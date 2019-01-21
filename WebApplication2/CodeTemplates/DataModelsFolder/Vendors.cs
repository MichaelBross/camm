using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Vendors.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Vendors 
    {	
		[Key]
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}      
