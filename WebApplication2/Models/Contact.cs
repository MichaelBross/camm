using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Contact 
    {	
		[Key]
        public int ContactId { get; set; }
        public string ContactNumber { get; set; }
        public string Size { get; set; }
        public string WireGageRange { get; set; }
        public string Family { get; set; }
        public string ContactNotes { get; set; }
    }
}      
