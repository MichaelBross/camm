using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ContactDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ContactDocuments 
    {	
		[Key]
        public int ContactDocId { get; set; }
        public int ContactId { get; set; }
        public int DocId { get; set; }
    }
}      
