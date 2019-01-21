using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a ToolDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class ToolDocuments 
    {	
		[Key]
        public int ToolDocId { get; set; }
        public int ToolId { get; set; }
        public int DocId { get; set; }
    }
}      
