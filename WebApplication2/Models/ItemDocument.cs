using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ItemDocument 
    {	
		[Key]
        public int ItemDocumentId { get; set; }
        public string ItemNumber { get; set; }
        public int DocId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}      
