using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ContactTools.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ContactTools 
    {	
		[Key]
        public int ContactToolId { get; set; }
        public int ContactId { get; set; }
        public int ToolId { get; set; }
    }
}      
