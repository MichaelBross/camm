using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    /// <summary>
    /// Represents a Operations.
    /// NOTE: This class is generated from a T4 template - you should not modify it manually.
    /// </summary>
    public class Operations 
    {	
		[Key]
        public int OperationId { get; set; }
        public string Description { get; set; }
    }
}      
