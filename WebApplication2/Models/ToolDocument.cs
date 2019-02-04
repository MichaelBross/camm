using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ToolDocument 
    {	
		[Key]
        public int ToolDocId { get; set; }
        public int ToolId { get; set; }
        public int DocId { get; set; }
    }
}      
