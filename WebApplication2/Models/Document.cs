using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Document 
    {	
		[Key]
        public int DocId { get; set; }
        public string DocNumber { get; set; }
        public string DocRev { get; set; }
        public string Title { get; set; }
        public string DocType { get; set; }
        public string DocStatus { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}      
