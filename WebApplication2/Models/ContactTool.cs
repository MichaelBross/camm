using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class ContactTool 
    {	
		[Key]
        public int ContactToolId { get; set; }
        public int ContactId { get; set; }
        public int ToolId { get; set; }
    }
}      
