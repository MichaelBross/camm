using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Vendor 
    {	
		[Key]
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}      
