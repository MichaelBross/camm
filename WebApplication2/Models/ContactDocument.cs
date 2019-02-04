using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ContactDocument
    {	
		[Key]
        public int ContactDocId { get; set; }
        public int ContactId { get; set; }
        public int DocId { get; set; }
    }
}      
