using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a AssemblyOperations.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class AssemblyOperations 
    {	
		[Key]
        public int AssemblyOperationId { get; set; }
        public int AssemblyId { get; set; }
        public int SequenceNumber { get; set; }
        public int OperationId { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}      
