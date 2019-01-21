using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Contacts.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Contacts 
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
