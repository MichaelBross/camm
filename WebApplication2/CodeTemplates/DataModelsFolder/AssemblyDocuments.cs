using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AssemblyDocuments.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyDocuments 
    {	
		[Key]
        public int AssemblyDocId { get; set; }
        public int AssemblyId { get; set; }
        public int DocId { get; set; }
    }
}      
